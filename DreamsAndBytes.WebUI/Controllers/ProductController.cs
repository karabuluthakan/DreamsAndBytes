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
        public ActionResult Index()
        {
            var products=  _productService.GetAll();
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products
            };
            return View(model);
        }
    }
}