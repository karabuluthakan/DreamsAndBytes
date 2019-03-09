using System.Collections.Generic;
using System.Linq;
using DreamsAndBytes.Business.Abstract;
using DreamsAndBytes.Entities.Concrete;

namespace DreamsAndBytes.Business.Concrete
{
    public class CartManager:ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(x => x.Product.ProductId == product.ProductId);
            if (cartLine!=null)
            {
                cartLine.Quantity++;
                return;
            }
            cart.CartLines.Add(new CartLine {Product = product,Quantity = 1});
        }

        public void RemoveFromCart(Cart cart, int productId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(x => x.Product.ProductId == productId));
        }

        public List<CartLine> List(Cart cart)
        {
           return cart.CartLines;
        }
    }
}