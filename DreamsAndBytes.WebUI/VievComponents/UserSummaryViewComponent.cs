using DreamsAndBytes.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace DreamsAndBytes.WebUI.VievComponents
{
    public class UserSummaryViewComponent:ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            
            UserDetailsViewModel model = new UserDetailsViewModel
            {
                UserName = HttpContext.User.Identity.Name
            };
            return View(model);
        }
    }
}