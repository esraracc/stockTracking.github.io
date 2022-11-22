
using BusinessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly DataLayer.Abstract.IUnitOfWork _unitOfWork;
        public CustomerManager(DataLayer.Abstract.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Create(Customer entity)
        {
            var result = _unitOfWork.Customers.Create(entity);
            if (result)
                return true;
            return false;
        }

        public bool Delete(Customer entity)
        {
            var result = _unitOfWork.Customers.Delete(entity);
            if (result)
                return true;
            return false;
        }

        public List<Customer> GetAll()
        {
            return _unitOfWork.Customers.GetAll();
        }

        public Customer GetById(int id)
        {
            return _unitOfWork.Customers.GetById(id);
        }

        public bool Update(Customer entity)
        {
            var result = _unitOfWork.Customers.Update(entity);
            if (result)
                return true;
            return false;
        }
    }
}
