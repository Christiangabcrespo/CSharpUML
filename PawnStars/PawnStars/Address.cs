using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnStars
{
    internal class Address
    {
        string street;
        string number;
        string postalCode;

        public string Street {  get { return street; } }
        public string Number { get { return number; } }
        public string PostalCode { get { return postalCode; } }

        public Address(string street, string number, string postalCode)
        {
            this.street = street;
            this.number = number;
            this.postalCode = postalCode;
        }
    }
}
