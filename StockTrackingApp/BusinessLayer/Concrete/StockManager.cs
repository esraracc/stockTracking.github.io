
using BusinessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StockManager : IStockService
    {
        private readonly DataLayer.Abstract.IUnitOfWork _unitOfWork;
        public StockManager(DataLayer.Abstract.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Create(Stock entity)
        {
            var result = _unitOfWork.Stocks.Create(entity);
            if (result)
                return true;
            return false;
        }

        public bool Delete(Stock entity)
        {
            var result = _unitOfWork.Stocks.Delete(entity);
            if (result)
                return true;
            return false;
        }

        public List<Stock> GetAll()
        {
            return _unitOfWork.Stocks.GetAll();
        }

        public Stock GetById(int id)
        {
            return _unitOfWork.Stocks.GetById(id);
        }

        public bool Update(Stock entity)
        {
            var result = _unitOfWork.Stocks.Update(entity);
            if (result)
                return true;
            return false;
        }
    }
}
