using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public enum ProductCategory
    {
        Food,
        HouseholdAppliances
    }

    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public ProductCategory Category { get; set; }
    }
}
