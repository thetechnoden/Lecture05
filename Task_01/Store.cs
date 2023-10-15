using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Store : ISearchable
    {
        private List<User> users;
        private List<Product> products;
        private List<Order> orders;

        public Store()
        {
            users = new List<User>();
            products = new List<Product>();
            orders = new List<Order>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void PlaceOrder(User user, List<Product> selectedProducts, List<int> quantities)
        {
            if (users.Contains(user))
            {
                var order = new Order(selectedProducts, quantities);
                orders.Add(order);
                user.PurchaseHistory.Add(order);
            }
            else
            {
                Console.WriteLine("No user found.");
            }
        }

        public void ProcessOrder(Order order)
        {
            if (orders.Contains(order))
            {
                order.Status = "Processed";
            }
            else
            {
                Console.WriteLine("Order not found.");
            }
        }

        public List<Product> SearchByName(string name)
        {
            return products.Where(p => p.Name.Contains(name)).ToList();
        }

        public List<Product> SearchByCategory(string category)
        {
            return products.Where(p => p.Category == category).ToList();
        }

        public List<Product> SearchByPriceRange(double minPrice, double maxPrice)
        {
            return products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
        }

        public List<Product> SearchByRating(int rating)
        {
            return products.Where(p => p.Rating == rating).ToList();
        }
    }

}
