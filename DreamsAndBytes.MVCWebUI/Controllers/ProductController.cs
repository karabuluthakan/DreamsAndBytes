using DreamsAndBytes.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace DreamsAndBytes.MVCWebUI.Controllers
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
            var products = _productService.GetAll();
            ProductListVie
            return View();
        }
    }
}