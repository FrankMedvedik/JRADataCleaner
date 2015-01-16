using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JRADataCleanUI
{
    public class Columns
    {
        public enum ChooseColumns
        {
            CompanyName = 1,
            RecordExtras = 2,
            Reserved = 3,
            NameFull = 4,
            Gender = 5,
            Gender2 = 6,
            Salutation = 7,
            NamePrefix = 8,
            NameFirst = 9,
            NameMiddle = 10,
            NameLast = 11,
            NameSuffix = 12,
            NamePrefix2 = 13,
            NameFirst2 = 14,
            NameMiddle2 = 15,
            NameLast2 = 16,
            NameSuffix2 = 17,
            AddressLine1 = 18,
            AddressLine2 = 19,
            Suite = 20,
            PrivateMailBox = 21,
            City = 22,
            CityAbbreviation = 23,
            State = 24,
            StateName = 25,
            PostalCode = 26,
            AddressTypeCode = 27,
            CountryCode = 31,
            CountryName = 32,
            DeliveryIndicator = 33,
            AddressKey = 34,
            FormattedAddress = 35,
            AddressExtras = 36,
            UrbanizationName = 37,
            Plus4 = 38,
            CarrierRoute = 39,
            DeliveryPointCode = 40,
            DeliveryPointCheckDigit = 41,
            AddressHouseNumber = 42,
            AddressPreDirection = 43,
            AddressStreetName = 44,
            AddressStreetSuffix = 45,
            AddressPostDirection = 46,
            AddressSuiteName = 47,
            AddressSuiteNumber = 48,
            AddressPrivateMailboxName = 49,
            AddressPrivateMailboxRange = 50,
            AddressRouteService = 51,
            AddressLockBox = 52,
            AddressDeliveryInstallation = 53,
            Latitude = 60,
            Longitude = 61,
            CountyName = 62,
            CountyFIPS = 63,
            CensusTract = 64,
            CensusBlock = 65,
            UTCOffset = 66,
            PlaceCode = 68,
            PlaceName = 69,
            CBSACode = 70,
            CBSATitle = 71,
            CBSALevel = 72,
            CBSADivisionCode = 73,
            CBSADivisionTitle = 74,
            CBSADivisionLevel = 75,
            CongressionalDistrict = 76,
            EmailAddress = 77,
            EmailResults = 78,
            DomainName = 79,
            MailboxName = 80,
            TopLevelDomain = 81,
            PhoneNumber = 82,
            PhoneResults = 83,
            AreaCode = 84,
            NewAreaCode = 85,
            PhonePrefix = 86,
            PhoneSuffix = 87,
            PhoneExtension = 88,
            HouseholdIncome = 89,
            LengthOfResidence = 90,
            OwnRent = 91,
            Occupation = 92,
            PresenceOfChildren = 93,
            MaritalStatus = 94,
            DateOfDeath = 95,
            DateOfBirth = 96,
            DemographicsGender = 97
        };


        public enum Groups
        {
            NameDetails = 0,
            ParsedAddress = 1,
            AddressDetails = 2,
            Census = 3,
            ParsedEmail = 4,
            ParsedPhone = 5,
            GeoCode = 6
        };



    }
}