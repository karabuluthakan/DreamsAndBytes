using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DreamsAndBytes.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DreamsAndBytes.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
    where TEntity:class,IEntity,new ()
    where TContext:DbContext,new ()
    {
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
               var data = context.Entry(entity);
                data.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var data = context.Entry(entity);
                data.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var data = context.Entry(entity);
                data.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}