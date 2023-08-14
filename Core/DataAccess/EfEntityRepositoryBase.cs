using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public class EfEntityRepositoryBase<TEntity, TApolloContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TApolloContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TApolloContext apolloContext = new TApolloContext())
            {
                var addedEntity = apolloContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                apolloContext.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TApolloContext apolloContext = new TApolloContext())
            {
                var deletedEntity = apolloContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                apolloContext.SaveChanges();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TApolloContext apolloContext = new TApolloContext())
            {
                return filter == null ? apolloContext.Set<TEntity>().ToList() : apolloContext.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TApolloContext apolloContext = new TApolloContext())
            {
                var uptadedEntity = apolloContext.Entry(entity);
                uptadedEntity.State = EntityState.Modified;
                apolloContext.SaveChanges();
            }
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TApolloContext apolloContext = new TApolloContext())
            {
                return apolloContext.Set<TEntity>().SingleOrDefault(filter);
            }
        }
    }
}