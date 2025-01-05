using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaruantTerminalSystem.Business.Abstract
{
    public interface IService<T> where T : class
    {
        void Create(T entity);
        void Delete(int Id);
        void Update(T entity);
        IEnumerable<T> GetAll();
        T GetById(int Id);
    }
}
