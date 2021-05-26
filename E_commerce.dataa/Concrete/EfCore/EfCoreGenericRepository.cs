using System.Collections.Generic;
using System.Linq;
using E_commerce.dataa.Abstract;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.dataa.Concrete.EfCore
{
    public class EfCoreGenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext context;
        public EfCoreGenericRepository(DbContext ctx)
        {
            context=ctx;
        }
        public void Create(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);                      
        }

        public void Delete(TEntity entity)
        {
            
            context.Set<TEntity>().Remove(entity);
            
        }

        public List<TEntity> GetAll()
        {
             
                return context.Set<TEntity>().ToList();
            
        }

        public TEntity GetById(int id)
        {
            
                return context.Set<TEntity>().Find(id);
            
        }

        public virtual void Update(TEntity entity)
        {
            
                context.Entry(entity).State =EntityState.Modified;
              
            
        }
    }
}