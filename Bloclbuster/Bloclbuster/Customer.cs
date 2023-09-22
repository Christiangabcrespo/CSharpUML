using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Bloclbuster
{
    internal class Customer
    {
        string firstName;
        string lastName;
        Adress address;
        int customerNumber;

        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public Adress Address { get { return address; } }
        public int CustomerNumber { get { return customerNumber; } }

        public Customer(string firstName, string lastName, Adress address, int customerNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.customerNumber = customerNumber;
        }
    }
}
