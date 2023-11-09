using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Address
    {
        public string City {  get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }

        public Address(string city, string street, string houseNumber, string postalCode)
        {
            City = city;
            Street = street;
            HouseNumber = houseNumber;
            PostalCode = postalCode;
        }
    }
}
