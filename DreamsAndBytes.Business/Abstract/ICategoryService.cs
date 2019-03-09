using System.Collections.Generic;
using DreamsAndBytes.Entities.Concrete;

namespace DreamsAndBytes.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}