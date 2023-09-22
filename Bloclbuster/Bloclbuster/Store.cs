using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bloclbuster
{
    internal class Store
    {
        Adress adress;
        Customer customer;
        Loan loan;
        List<Customer> customers;
        Loan loan1;

        public Adress Address { get { return adress; } }
        public Customer Customer { get { return customer; } }
        public Loan Loan { get { return loan; } }


        public Store(Adress adress, Customer customers, Loan loans)
        {
            this.adress = adress;
            this.customer = customers;
            this.loan = loan;
        }

        public Store(Adress adress, List<Customer> customers, Loan loan1)
        {
            this.adress = adress;
            this.customers = customers;
            this.loan1 = loan1;
        }
    }
}
