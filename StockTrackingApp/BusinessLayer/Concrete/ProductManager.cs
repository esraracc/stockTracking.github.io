
using BusinessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly DataLayer.Abstract.IUnitOfWork _unitOfWork;
        public ProductManager(DataLayer.Abstract.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Create(Product entity)
        {
            var result = _unitOfWork.Products.Create(entity);
            if (result)
                return true;
            return false;
        }

        public bool Delete(Product entity)
        {
            var result = _unitOfWork.Products.Delete(entity);
            if (result)
                return true;
            return false;
        }

        public List<Product> GetAll()
        {
            return _unitOfWork.Products.GetAll();
        }

        public Product GetById(int id)
        {
            return _unitOfWork.Products.GetById(id);
        }

        public bool Update(Product entity)
        {
            var result = _unitOfWork.Products.Update(entity);
            if (result)
                return true;
            return false;
        }
    }
}
