using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PawnStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products("Computadora", 5000, false);
            Products product2 = new Products("Mesa", 7000.50, true);
            Products product3 = new Products("Silla", 2000, true);

            List<Products> products = new List<Products>();

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);

            products.Remove(product3);

            Address address1 = new Address("Calle Falsa", "123", "7013");
            Store store1 = new Store("Surcursal1", address1, 23, products);

            Console.WriteLine($"La tienda '{store1.Name}' tiene {store1.Products.Count} productos en inventario.");

            foreach (var product in store1.Products)
            {
                Console.WriteLine($"Producto: {product.Name}, Precio: {product.Price}, En venta: {product.OnSale}");
            }

            Console.ReadKey();
        }
    }
}
