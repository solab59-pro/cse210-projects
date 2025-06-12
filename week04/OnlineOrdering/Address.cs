using System;
using System.Collections.Generic;

  // Address class
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string Country { get; set; }

        public Address(string street, string city, string stateOrProvince, string country)
        {
            Street = street;
            City = city;
            StateOrProvince = stateOrProvince;
            Country = country;
        }

        public bool IsInUSA()
        {
            return Country.Trim().ToUpper() == "USA";
        }

        public string GetFullAddress()
        {
            return $"{Street}\n{City}, {StateOrProvince}\n{Country}";
        }
    }