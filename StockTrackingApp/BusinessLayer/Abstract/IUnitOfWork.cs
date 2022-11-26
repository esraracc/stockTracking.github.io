using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUnitOfWork
    {
        ICustomerService Customers { get; }
        IProductService Products { get; }
        IStockService Stocks { get; }
        ISaleService Sales { get; }
    }
}
