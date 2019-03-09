using System;
using DreamsAndBytes.Business.Abstract;
using DreamsAndBytes.Entities.Concrete;
using DreamsAndBytes.WebUI.Models;
using DreamsAndBytes.WebUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DreamsAndBytes.WebUI.Controllers
{
    public class CartController:Controller
    {
        private readonly ICartSessionService _cartSessionService;
        private readonly ICartService _cartService;
        private readonly IProductService _productService;

        public CartController(ICartSessionService cartSessionService,ICartService cartService,IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public ActionResult AddToCart(int productId)
        {
            var productToAdded = _productService.GetById(productId);
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart,productToAdded);
            _cartSessionService.SetCart(cart);

            TempData.Add("message", String.Format("Succesfully added to cart! Your product {0}",productToAdded.ProductName));
            
           return  RedirectToAction("Index", "Product");
        }

        public ActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartListViewModel cartListViewModel = new CartListViewModel
            {
                Cart = cart
            }; 
            return View(cartListViewModel);
        }
        
        public ActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart,productId);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", String.Format("Your product was successfully removed from the cart!"));
            return RedirectToAction("List");
        }
        
        public ActionResult Complete()
        {
            var shippingDetailsViewModel = new ShippingDetailsViewModel
            {
                ShippingDetails = new ShippingDetails()
            };
            return View(shippingDetailsViewModel);
        }

        [HttpPost]
        public ActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message",String.Format("Thank you {0}, you order is in process",shippingDetails.FirstName));
            return View();
        }
    }
}