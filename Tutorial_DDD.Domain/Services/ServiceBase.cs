using System;
using System.Collections.Generic;
using Tutorial_DDD.Domain.Interfaces.Repositories;
using Tutorial_DDD.Domain.Interfaces.Services;

namespace Tutorial_DDD.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void ADD(TEntity obj)
        {
            _repository.ADD(obj);
        }
        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }               

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }
        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
