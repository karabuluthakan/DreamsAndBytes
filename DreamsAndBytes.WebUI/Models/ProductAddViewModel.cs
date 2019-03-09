using System.Collections.Generic;
using DreamsAndBytes.Entities.Concrete;

namespace DreamsAndBytes.WebUI.Models
{
    public class ProductAddViewModel
    {
        public List<Category> Categories { get; internal set; }
        public Product Product { get; set; }
    }
}