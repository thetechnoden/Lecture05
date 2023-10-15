using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Order
    {
        public List<Product> Products { get; set; }
        public List<int> Quantities { get; set; }
        public double TotalCost { get; set; }
        public string Status { get; set; }

        public Order(List<Product> products, List<int> quantities)
        {
            Products = products;
            Quantities = quantities;
            CalculateTotalCost();
            Status = "In processing";
        }

        private void CalculateTotalCost()
        {
            TotalCost = 0;
            for (int i = 0; i < Products.Count; i++)
            {
                TotalCost += Products[i].Price * Quantities[i];
            }
        }
    }

}
