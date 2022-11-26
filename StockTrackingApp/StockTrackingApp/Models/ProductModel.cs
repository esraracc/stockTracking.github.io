using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrackingApp.Models
{
    public class ProductModel : Base
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
        public int TotalStock { get; set; }
        public decimal ExpectedProfit { get; set; }

        public List<Product> Products { get; set; }
    }
}
