using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PawnStars
{
    internal class Store
    {
        string name;

        
        string address;
        int number;
        

        public string Name { get { return name; } }
        
        public string Address { get { return address; } }
        public int Number { get { return number; } }
        

        public List<Products> Products;
        
        public Store(string name, string adress, int number, List<Products> products)
        {
            this.name = name; 
            this.address = adress;
            this.number = number;
            this.Products = products;
        }
        

        public Store(string v1, Address address1, int v2, List<Products> products)
        {
            Products = products;
        }

        public void AddProduct(Products product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Products product)
        {
            Products.Remove(product);
        }
    }
}
