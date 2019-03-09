using DreamsAndBytes.Entities.Concrete;
using DreamsAndBytes.WebUI.ExtensionsMethods;
using Microsoft.AspNetCore.Http;

namespace DreamsAndBytes.WebUI.Services
{
    public class CartSessionManager:ICartSessionService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CartSessionManager(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public Cart GetCart()
        {
          Cart cartToCheck=  _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            if (cartToCheck==null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("cart",new Cart());
                cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            }

            return cartToCheck;
        }

        public void SetCart(Cart cart)
        {
           _httpContextAccessor.HttpContext.Session.SetObject("cart",cart);
        }
    }
}