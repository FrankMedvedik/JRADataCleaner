using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using DataClean.Personator;
using log4net;
using Newtonsoft.Json;

namespace DataClean 
{
    public class DataCleaner : IDataCleaner
    {
        private const int MaxArraySize = 100;
        private static readonly ILog Logger =
            LogManager.GetLogger(typeof (DataCleaner));

        private Request _req;
        private Response _resp;
        private ServicemdContactVerifySOAPClient _action;
        private int _arraysize;
        private ParseResultDictionary _msgDict; 
        

        public DataCleaner(NameValueCollection c)
        {
            Initialize(c);
        }

        private void Initialize(NameValueCollection c)
        {
            String ClientID =c["PersonatorClientID"];
            String PersonatorActions = c["PersonatorActions"];
            String PersonatorOptions = c["PersonatorOptions"];

            if (ClientID == null)
            {
                var t = "ClientID Not Specified in app config file";
                Logger.Error(t);
                throw (new Exception(t));
            }

            if (PersonatorActions == null)
            {
                var u = "http://wiki.melissadata.com/index.php?title=Personator%3ABest_Practices";
                var t = String.Format("No actions specified in the app config file see: {0} ", u);
                Logger.Error(t);
                throw (new Exception(t));
            }

            Logger.Info(String.Format("Melissa ClientId {0}", ClientID));
            Logger.Info(String.Format("Melissa Personator Actions - {0}", PersonatorActions));
            Logger.Info(String.Format("Melissa Personator Options - {0}", PersonatorOptions));


            _req = new Request();
            _req.Actions = PersonatorActions;
            _req.Options = PersonatorOptions;
            _resp = new Response();
            _action = new ServicemdContactVerifySOAPClient(); //"BasicHttpBinding_IService");
            _req = new Request {CustomerID = ClientID, TransmissionReference = "JRA Personator SOAP Web Service "};
            _msgDict = new ParseResultDictionary();
        }

        public Boolean VerifyAndCleanAddress(InputStreetAddress inA, out OutputStreetAddress outA)
        {
            /* use settings from config file and process 1 record */
            var iArray = new[] {inA};
            var oArray = VerifyAndCleanAddress(iArray);
            outA = oArray[0];
            return true;// !oArray[0].Errors.Any();
        }

        public OutputStreetAddress[] VerifyAndCleanAddress(InputStreetAddress[] inputAddressArray)
        {

            
            if (inputAddressArray.Length > MaxArraySize)
                throw new Exception(String.Format("Too Many Items in Request maximum number is {0}", MaxArraySize));
            _arraysize = inputAddressArray.Length;
            var rra = new RequestRecord[_arraysize];
            var x = 0;
            foreach (var i in inputAddressArray)
                rra[x++] = new RequestRecord(i);
            _req.Records = rra;

            try
            {
                // the transmission results tell us if we got far enough to process records. if it is blank the answer is yes 
                // if we got transmission results we have a broke - connection and or configuration 
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
                var t = GetTransmissionErrors();
                string exText = null;
                foreach (var a in t)
                    exText += a.ToString() + Environment.NewLine;
                throw new Exception(exText);
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