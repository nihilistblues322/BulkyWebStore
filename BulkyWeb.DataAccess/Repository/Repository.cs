using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BulkyWeb.DataAccess.Data;
using BulkyWeb.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.DataAccess.Repository
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
            _db.Products.Include(u => u.Category).Include(u => u.CategoryId);
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> predicate, string? includeProp = null)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(predicate);
            if (!string.IsNullOrEmpty(includeProp))
            {
                foreach (
                    var prop in includeProp.Split(
                        new char[] { ',' },
                        StringSplitOptions.RemoveEmptyEntries
                    )
                )
                {
                    query = query.Include(prop);
                }
            }
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll(string? includeProp = null)
        {
            IQueryable<T> query = dbSet;
            if (!string.IsNullOrEmpty(includeProp))
            {
                foreach (
                    var prop in includeProp.Split(
                        new char[] { ',' },
                        StringSplitOptions.RemoveEmptyEntries
                    )
                )
                {
                    query = query.Include(prop);
                }
            }
            return query.ToList();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
        }
    }
}
