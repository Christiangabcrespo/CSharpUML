using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bloclbuster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();  
            List<Movie> movies = new List<Movie>();
            List<Store> stores = new List<Store>();

            Adress adress = new Adress("La Rioja", 1232, "2343");

            Customer customer1 = new Customer("Alejo", "Garcia", adress, 23);

            Movie movie1 = new Movie("The avengers", Genre.Action, 120);
            Loan loan1 = new Loan(customer1, movie1, DateTime.Now, 120);
            Store store1 = new Store(adress, customer1, loan1);

            customers.Add(customer1);
            movies.Add(movie1);
            stores.Add(store1);

            foreach (var customer in customers)
            {
                Console.WriteLine($"Nombre cliente: {customer.FirstName} {customer.LastName}");
                Console.WriteLine($"Direccion Cliente: {customer.Address.Street} {customer.Address.Number}, {customer.Address.City}");
                Console.WriteLine($"Numero de cliente: {customer.CustomerNumber}");
                Console.WriteLine();
            }

            foreach (var movie in movies)
            {
                Console.WriteLine($"Titulo de la pelicula: {movie.Title}");
                Console.WriteLine($"Genero de la pelicula: {movie.Genre}");
                Console.WriteLine($"Duracion: {movie.Duration} minutos");
                Console.WriteLine();
            }

            foreach (var store in stores)
            {
                Console.WriteLine($"Direccion de la tienda: {store.Address.Street} {store.Address.Number}, {store.Address.City}");
                Console.WriteLine($"Clientes de la tienda: {store.Customer.FirstName} {store.Customer.LastName}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
