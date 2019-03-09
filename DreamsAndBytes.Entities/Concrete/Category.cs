using DreamsAndBytes.Core.Entities;

namespace DreamsAndBytes.Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}