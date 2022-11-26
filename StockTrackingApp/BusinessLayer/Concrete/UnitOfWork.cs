using BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataLayer.Abstract.IUnitOfWork unitOfWork;
        public UnitOfWork(DataLayer.Abstract.IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        private CustomerManager _customerManager;
        private ProductManager _productManager;
        private StockManager _stockManager;
        private SaleManager _saleManager;


        public ICustomerService Customers => _customerManager ??= new CustomerManager(unitOfWork);
        public IProductService Products => _productManager ??= new ProductManager(unitOfWork);
        public IStockService Stocks => _stockManager ??= new StockManager(unitOfWork);
        public ISaleService Sales => _saleManager ??= new SaleManager(unitOfWork);

    }
}
