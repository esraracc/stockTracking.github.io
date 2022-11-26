using DataLayer.Abstract;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Concrete.EfCore
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
        public UnitOfWork(Context context)
        {
            _context = context;
        }

        private EfCoreCustomerRepository _customerRepository;
        private EfCoreProductRepository _productRepository;
        private EfCoreStockRepository _stockRepository;
        private EfCoreSaleRepository _saleRepository;


        public ICustomerRepository Customers => _customerRepository ??= new EfCoreCustomerRepository(_context);
        public IProductRepository Products => _productRepository ??= new EfCoreProductRepository(_context);
        public IStockRepository Stocks => _stockRepository ??= new EfCoreStockRepository(_context);
        public ISaleRepository Sales => _saleRepository ??= new EfCoreSaleRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
