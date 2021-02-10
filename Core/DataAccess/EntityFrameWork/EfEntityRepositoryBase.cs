using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFrameWork
{
    public class EfEntityRepositoryBase<TEntiy, TContext>: IEntityRepository<TEntiy>
        where TEntiy:class, IEntity, new()
        where TContext:DbContext, new()
       
    {
        public void Add(TEntiy entity)
        {
            using (TContext context = new TContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntiy entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
            }
        }

        public TEntiy Get(Expression<Func<TEntiy, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntiy>().SingleOrDefault(filter);
            }
        }

        public List<TEntiy> GetAll(Expression<Func<TEntiy, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntiy>().ToList()
                    : context.Set<TEntiy>().Where(filter).ToList();
            }

        }

        public void Update(TEntiy entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
