using DocumentFormat.OpenXml.Vml.Office;
using FersaTech.Services.Database.Service.Interfaces;
using System.Data.Entity;

namespace FersaTech.Services.Database.Service.Respositories
{
    public class DbManager<TEntity> : IDbManager<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext dbContext;
        public DbManager(ApplicationDbContext dbContext) => this.dbContext = dbContext;

        public void Add(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity); ;
            dbContext.SaveChanges();
        }

        public TEntity AddEntity(TEntity entity)
        {
            var ent = dbContext.Set<TEntity>().Add(entity);
            dbContext.SaveChanges();
            return ent.Entity;
        }

        public void AddRange(List<TEntity> entities)
        {
            dbContext.Set<TEntity>().AddRange(entities);
            dbContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            dbContext.Set<TEntity>().Remove(entity);
            dbContext.SaveChanges();
        }       

        public IQueryable<TEntity> GetAll() 
        {
            var entity = dbContext.Set<TEntity>();
            return entity;
        }

        public void Update(TEntity entity)
        {
            dbContext.Set<TEntity>().Update(entity);
            dbContext.SaveChanges();
        }
    }
}
