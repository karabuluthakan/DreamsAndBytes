using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DreamsAndBytes.Core.Entities;

namespace DreamsAndBytes.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new ()
    {
        T Get(Expression<Func<T,bool>>filter=null);
        List<T> GetList(Expression<Func<T,bool>>filter=null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}