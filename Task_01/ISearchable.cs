using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    interface ISearchable
    {
        List<Product> SearchByName(string name);
        List<Product> SearchByCategory(string category);
        List<Product> SearchByPriceRange(double minPrice, double maxPrice);
        List<Product> SearchByRating(int rating);
    }
}
