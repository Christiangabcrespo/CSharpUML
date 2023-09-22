using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnStars
{
    public enum State
    {
        BAD,
        REGULAR,
        GOOD
    }

    public enum Category
    {
        ANTIQUES,
        JEWELRY,
        VALUABLEITEMS
    }
    internal class Products
    {
        string name;
        double price; 
        bool onSale;
     
        public string Name {get { return name; } }
        public double Price { get { return price; } }
        public bool OnSale { get {  return onSale; } }

        public Products(string name, double price, bool onSale)
        {
            this.name = name;
            this.price = price;
            this.onSale = onSale;
        }
    }
}