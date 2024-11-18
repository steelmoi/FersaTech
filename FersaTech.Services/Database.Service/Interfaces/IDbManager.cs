using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FersaTech.Services.Database.Service.Interfaces
{
    public interface IDbManager<TEntity> where TEntity : class
    {
        void AddRange(List<TEntity> entities);
        TEntity AddEntity(TEntity entity);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        IQueryable<TEntity> GetAll();
    }
}
