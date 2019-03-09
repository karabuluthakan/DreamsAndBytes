using System.Collections.Generic;
using DreamsAndBytes.Entities.Concrete;

namespace DreamsAndBytes.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart, int productId);
        List<CartLine> List(Cart cart);
    }
}