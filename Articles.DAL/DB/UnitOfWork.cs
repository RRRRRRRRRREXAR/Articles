using Articles.DAL.Entities;
using Articles.DAL.Interfaces;
using Articles.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.DAL.DB
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ArticleContext _db;
        public Dictionary<Type, object> _repositories = new Dictionary<Type, object>();
        private bool _disposed = false;
        public UnitOfWork(ArticleContext context)
        {
            _db = context;
        }

        public IRepository<T> Repository<T>() where T : BaseEntity
        {
            if (_repositories.ContainsKey(typeof(T)) == true)
            {
                return _repositories[typeof(T)] as Repository<T>;
            }

            IRepository<T> repo = new Repository<T>(_db);
            _repositories.Add(typeof(T), repo);
            return repo;
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (_disposed)
                {
                    _db.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
