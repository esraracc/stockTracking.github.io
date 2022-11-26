using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Stock : Base
    {
        public string Description { get; set; }
        public int Total { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
