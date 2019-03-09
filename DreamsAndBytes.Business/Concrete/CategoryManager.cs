using System.Collections.Generic;
using DreamsAndBytes.Business.Abstract;
using DreamsAndBytes.DataAccess.Abstract;
using DreamsAndBytes.Entities.Concrete;

namespace DreamsAndBytes.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private  ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}