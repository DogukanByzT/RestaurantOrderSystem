using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTerminalSystem.DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
    }
}
