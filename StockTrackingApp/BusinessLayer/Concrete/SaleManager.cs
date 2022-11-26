
using BusinessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SaleManager : ISaleService
    {
        private readonly DataLayer.Abstract.IUnitOfWork _unitOfWork;
        public SaleManager(DataLayer.Abstract.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Create(Sale entity)
        {
            var result = _unitOfWork.Sales.Create(entity);
            if (result)
                return true;
            return false;
        }

        public bool Delete(Sale entity)
        {
            var result = _unitOfWork.Sales.Delete(entity);
            if (result)
                return true;
            return false;
        }

        public List<Sale> GetAll()
        {
            return _unitOfWork.Sales.GetAll();
        }

        public Sale GetById(int id)
        {
            return _unitOfWork.Sales.GetById(id);
        }

        public bool Update(Sale entity)
        {
            var result = _unitOfWork.Sales.Update(entity);
            if (result)
                return true;
            return false;
        }
    }
}
