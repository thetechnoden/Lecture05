using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new Store();

            var user1 = new User("user1", "password1");
            var user2 = new User("user2", "password2");
            store.AddUser(user1);
            store.AddUser(user2);

            var product1 = new Product("Product 1", 100, "Product description 1", "Category 1", 4);
            var product2 = new Product("Product 2", 150, "Product description 2", "Category 2", 3);
            var product3 = new Product("Product 3", 50, "Product description 3", "Category 1", 5);
            store.AddProduct(product1);
            store.AddProduct(product2);
            store.AddProduct(product3);
           
            var searchResults = store.SearchByCategory("Category 1");
            Console.WriteLine("Search results by category 'Category 1':");
            foreach (var product in searchResults)
            {
                Console.WriteLine(product.Name);
            }
            
            var selectedProducts = new List<Product> { product1, product3 };
            var quantities = new List<int> { 2, 1 };
            store.PlaceOrder(user1, selectedProducts, quantities);
            var orderToProcess = user1.PurchaseHistory.First();
            store.ProcessOrder(orderToProcess);

            Console.ReadLine();
        }
    }
}