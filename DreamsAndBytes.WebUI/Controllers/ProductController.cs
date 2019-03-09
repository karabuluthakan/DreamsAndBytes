using System;
using System.Linq;
using DreamsAndBytes.Business.Abstract;
using DreamsAndBytes.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DreamsAndBytes.WebUI.Controllers
{
    public class ProductController:Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index(int page=1,int categroy=0)
        {
            int pageSize = 10;
           
            var products=  _productService.GetAll();
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.Skip((page-1)*pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(products.Count/(double)pageSize),
                PageSize=pageSize,
                CurrentCategory = categroy,
                CurrentPage=page
            };
            return View(model);
        }
 
    }
}