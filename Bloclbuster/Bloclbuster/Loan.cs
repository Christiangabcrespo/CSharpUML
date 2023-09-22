using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloclbuster
{
    internal class Loan
    {
        Customer customer;
        Movie movie;
        DateTime loanDate;
        int numberOfDays;

        public Customer Customer { get { return customer; } }
        public Movie Movie { get { return movie; } }
        public DateTime LoanDate { get { return loanDate; } }
        public int NumberOfDaysm {get { return numberOfDays; }}

        public Loan(Customer customer, Movie movie, DateTime loanDate, int numberOfDays)
        {
            this.customer = customer;
            this.movie = movie;
            this.loanDate = loanDate;
            this.numberOfDays = numberOfDays;
        }
    }
}
