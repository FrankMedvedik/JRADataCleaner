using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JRAMelissaWrapper.Personator;
using log4net;
using Newtonsoft.Json;

namespace JRAMelissaWrapper
{
    public class DataCleaner : IDataClean
    {
        private const int MaxArraySize = 100;
        private const string CustomerId = "CHANGEMEDAVE";

        private static readonly ILog Logger =
            LogManager.GetLogger(typeof (DataCleaner));

        private Request _req;
        private Response _resp;
        private ServicemdContactVerifySOAPClient _action;
        private int _arraysize;
        private ParseResultDictionary _msgDict; 

        public DataCleaner()
        {
            Initialize();
        }

        private void Initialize()
        {
            _req = new Request();
            _resp = new Response();
            _action = new ServicemdContactVerifySOAPClient(); //"BasicHttpBinding_IService");
            _req = new Request {CustomerID = CustomerId, TransmissionReference = "JRA Personator SOAP Web Service "};
            _arraysize = 1;
            _req.Records = new RequestRecord[_arraysize];
            _msgDict = new ParseResultDictionary();
        }

        public Boolean VerifyAndCleanAddress(InputStreetAddress inA, out OutputStreetAddress outA)
        {
            /* use defaults and process 1 record */
            _arraysize = 1;
            ActionCheck = true;
            ActionVerify = true;

            var iArray = new[] {inA};
            var oArray = VerifyAndCleanAddress(iArray);
            outA = oArray[0];
            return !oArray[0].Errors.Any();
        }

        public OutputStreetAddress[] VerifyAndCleanAddress(InputStreetAddress[] inputAddressArray)
        {
            if (inputAddressArray.Length > MaxArraySize)
                throw new Exception(String.Format("Too Many Items in Request maximum number is {0}", MaxArraySize));
            _arraysize = inputAddressArray.Length;

            /* actions shuld be set up 1st! */
            //ActionCheck = true;
            //ActionVerify = true;

            _req.Options = SetActions();
            var x = 0;
            foreach (var i in inputAddressArray)
                _req.Records[x++] = new RequestRecord(i);

            try
            {
                _resp = _action.doContactVerify(_req);
                if (_resp.TransmissionResults.Trim() == "")
                {
                    var o = new OutputStreetAddress[_resp.Records.Length];
                    int i = 0;
                    foreach (var r in _resp.Records)
                    {
                        o[i++] = ProcessResponseRecord(r);
                    }
                    return o;
                }
                else
                {
                    var t = GetTransmissionErrors();
                    string exText = null;
                    foreach (var a in t)
                        exText += a.ToString() + Environment.NewLine;
                    throw new Exception(exText);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw;
            }

        }

        private IParseResult[] GetTransmissionErrors()
        {
            return _msgDict.LookupCodeList(_resp.TransmissionResults.Split(','));
        }

        public Boolean ActionCheck { get; set; }
        public Boolean ActionVerify { get; set; }
        public Boolean ActionAppend { get; set; }
        public Boolean ActionMove { get; set; }

        private string SetActions()
        {
            string actions = "";

            if (ActionCheck) actions += "Check,";
            if (ActionVerify) actions += "Verify,";
            if (ActionAppend) actions += "Append,";
            if (ActionMove) actions += "Move,";

            actions = actions.TrimEnd(',');

            return actions;
        }

        private OutputStreetAddress ProcessResponseRecord(ResponseRecord respRec)
        {

            var o = new OutputStreetAddress()
            {
                AddressDeliveryInstallation = respRec.AddressDeliveryInstallation,
                AddressExtras = respRec.AddressExtras,
                AddressHouseNumber = respRec.AddressHouseNumber,
                AddressKey = respRec.AddressKey,
                AddressLine1 = respRec.AddressLine1,
                AddressLine2 = respRec.AddressLine2,
                AddressLockBox = respRec.AddressLockBox,
                AddressPostDirection = respRec.AddressPostDirection,
                AddressPreDirection = respRec.AddressPreDirection,
                AddressPrivateMailboxName = respRec.AddressPrivateMailboxName,
                AddressPrivateMailboxRange = respRec.AddressPrivateMailboxRange,
                AddressRouteService = respRec.AddressRouteService,
                AddressStreetName = respRec.AddressStreetName,
                AddressStreetSuffix = respRec.AddressStreetSuffix,
                AddressSuiteName = respRec.AddressSuiteName,
                AddressSuiteNumber = respRec.AddressSuiteNumber,
                AddressTypeCode = respRec.AddressTypeCode,
                AreaCode = respRec.AreaCode,
                CBSACode = respRec.CBSACode,
                CBSADivisionCode = respRec.CBSADivisionCode,
                CBSADivisionLevel = respRec.CBSADivisionLevel,
                CBSADivisionTitle = respRec.CBSADivisionTitle,
                CBSALevel = respRec.CBSALevel,
                CBSATitle = respRec.CBSATitle,
                CarrierRoute = respRec.CarrierRoute,
                CensusBlock = respRec.CensusBlock,
                CensusTract = respRec.CensusTract,
                City = respRec.City,
                CityAbbreviation = respRec.CityAbbreviation,
                CompanyName = respRec.CompanyName,
                CongressionalDistrict = respRec.CongressionalDistrict,
                CountryCode = respRec.CountryCode,
                CountryName = respRec.CountryName,
                CountyFIPS = respRec.CountyFIPS,
                CountyName = respRec.CountyName,
                DateOfBirth = respRec.DateOfBirth,
                DateOfDeath = respRec.DateOfDeath,
                DeliveryIndicator = respRec.DeliveryIndicator,
                DeliveryPointCheckDigit = respRec.DeliveryPointCheckDigit,
                DeliveryPointCode = respRec.DeliveryPointCode,
                DemographicsGender = respRec.DemographicsGender,
                DemographicsResults = respRec.DemographicsResults,
                DomainName = respRec.DomainName,
                EmailAddress = respRec.EmailAddress,
                Gender = respRec.Gender,
                Gender2 = respRec.Gender2,
                HouseholdIncome = respRec.HouseholdIncome,
                Latitude = respRec.Latitude,
                LengthOfResidence = respRec.LengthOfResidence,
                Longitude = respRec.Longitude,
                MailboxName = respRec.MailboxName,
                MaritalStatus = respRec.MaritalStatus,
                NameFirst = respRec.NameFirst,
                NameFirst2 = respRec.NameFirst2,
                NameFull = respRec.NameFull,
                NameLast = respRec.NameLast,
                NameLast2 = respRec.NameLast2,
                NameMiddle = respRec.NameMiddle,
                NameMiddle2 = respRec.NameMiddle2,
                NamePrefix = respRec.NamePrefix,
                NamePrefix2 = respRec.NamePrefix2,
                NameSuffix = respRec.NameSuffix,
                NameSuffix2 = respRec.NameSuffix2,
                NewAreaCode = respRec.NewAreaCode,
                Occupation = respRec.Occupation,
                OwnRent = respRec.OwnRent,
                PhoneExtension = respRec.PhoneExtension,
                PhoneNumber = respRec.PhoneNumber,
                PhonePrefix = respRec.PhonePrefix,
                PhoneSuffix = respRec.PhoneSuffix,
                PlaceCode = respRec.PlaceCode,
                PlaceName = respRec.PlaceName,
                Plus4 = respRec.Plus4,
                PostalCode = respRec.PostalCode,
                PresenceOfChildren = respRec.PresenceOfChildren,
                PrivateMailBox = respRec.PrivateMailBox,
                RecordExtras = respRec.RecordExtras,
                Results = _msgDict.LookupCodeList(respRec.Results.Split(',')),
                Salutation = respRec.Salutation,
                State = respRec.State,
                StateName = respRec.StateName,
                Suite = respRec.Suite,
                TopLevelDomain = respRec.TopLevelDomain,
                UTC = respRec.UTC,
                UrbanizationName = respRec.UrbanizationName
            };
            return o;
        }
    }
}