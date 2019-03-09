using System.Collections.Generic;
using DreamsAndBytes.Entities.Concrete;

namespace DreamsAndBytes.WebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int CurrentCategory { get; set; }
    }
}