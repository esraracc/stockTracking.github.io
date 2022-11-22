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


        public ICustomerService Customers => _customerManager ??= new CustomerManager(unitOfWork);

    }
}
