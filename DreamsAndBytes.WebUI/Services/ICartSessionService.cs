using DreamsAndBytes.Entities.Concrete;

namespace DreamsAndBytes.WebUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}