using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloclbuster
{
    internal class Adress
    {
        string street;
        int number;
        string city;

        public string Street { get { return street; } }
        public int Number { get { return number; } }
        public string City { get { return city; } }

        public Adress(string street, int number, string city)
        {
            this.street = street;
            this.number = number;
            this.city = city;
        }
    }
}
