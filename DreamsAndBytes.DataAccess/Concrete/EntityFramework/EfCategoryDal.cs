using DreamsAndBytes.Core.DataAccess.EntityFramework;
using DreamsAndBytes.DataAccess.Abstract;
using DreamsAndBytes.Entities.Concrete;

namespace DreamsAndBytes.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,AppContext>,ICategoryDal
    {
        
    }
}