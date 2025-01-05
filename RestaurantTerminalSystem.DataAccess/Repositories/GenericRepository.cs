using Microsoft.EntityFrameworkCore;
using RestaurantTerminalSystem.DataAccess.Abstract;
using RestaurantTerminalSystem.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTerminalSystem.DataAccess.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext dbContext;
        private readonly DbSet<T> dbSet;

        public GenericRepository(ApplicationDbContext _context)
        {
            dbContext = _context;
            dbSet = dbContext.Set<T>();
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
            dbContext.SaveChanges();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
           return dbSet.Where(predicate).ToList();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
            dbContext.SaveChanges();
        }
    }
}
