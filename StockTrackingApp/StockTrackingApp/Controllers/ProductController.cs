using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using StockTrackingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrackingApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new ProductModel()
            {
                Products = _unitOfWork.Products.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult AddProduct(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = _mapper.Map<Product>(model);
                model.ExpectedProfit = (model.SalePrice - model.CostPrice) * model.TotalStock;
                _unitOfWork.Products.Create(entity);
                return RedirectToAction("Index");
            }
            model.Products = _unitOfWork.Products.GetAll();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditProduct(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = _unitOfWork.Products.GetById(model.Id);
                if (entity != null)
                {
                    var entityProduct = _mapper.Map<ProductModel, Product>(model, entity);
                    entityProduct.ExpectedProfit = (model.SalePrice - model.CostPrice) * model.TotalStock;
                    _unitOfWork.Products.Update(entityProduct);
                }
            }
            model.Products = _unitOfWork.Products.GetAll();
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult DeleteProduct(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = _unitOfWork.Products.GetById(model.Id);
                if (entity != null)
                {
                    _unitOfWork.Products.Delete(entity);
                }
            }

            model.Products = _unitOfWork.Products.GetAll();
            return RedirectToAction("Index");
        }
    }
}
