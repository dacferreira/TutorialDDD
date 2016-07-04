using System.Collections.Generic;

namespace Tutorial_DDD.Domain.Interfaces.Repositories
{
    /// <summary>
    /// TEntity será generico e será do tipo classe
    /// deverão ter os métodos genericos (CRUD)
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
   public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void ADD(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
