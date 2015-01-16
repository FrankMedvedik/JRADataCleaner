﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRAMelissaWrapper.Personator;

namespace JRAMelissaWrapper.Personator
{
    public partial class RequestRecord 
    {
        private InputStreetAddress i;

        public RequestRecord(IInputStreetAddress a)
        {
            AddressLine1 = a.AddressLine1;
            AddressLine2 = a.AddressLine2;
            City = a.City;
            CompanyName = a.CompanyName;
            Country = a.Country;
            EmailAddress = a.EmailAddress;
            FirstName = a.FirstName;
            FullName = a.FullName;
            LastName = a.LastName;
            PhoneNumber = a.PhoneNumber;
            PostalCode = a.PostalCode;
            State = a.State;
        }
    }

}