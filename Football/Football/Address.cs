using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Address
    {
        string street;
        int number;
        string city;

        public string Street { get { return street; } }
        public int Height { get { return number; } }

        public Address(string street, int number, string city)
        {
            this.street = street;
            this.number = number;
            this.city = city;
        }
        public override string ToString()
        {
            return "- " + street + " " + number + ", " + city + ".";
        }
    }
}
