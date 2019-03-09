using System.Collections.Generic;
using DreamsAndBytes.Entities.Concrete;

namespace DreamsAndBytes.WebUI.Models
{
    public class ProductUpdateViewModel
    {
        public List<Category> Categories { get; set; }
        public Product Product { get; set; }
    }
}