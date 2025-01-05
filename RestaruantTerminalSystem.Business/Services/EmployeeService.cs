using RestaruantTerminalSystem.Business.Abstract;
using RestaurantTerminalSystem.DataAccess.Repositories;
using RestaurantTerminalSystem.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaruantTerminalSystem.Business.Services
{
    public class EmployeeService : IService<Employee>
    {
        private readonly EmployeeRepository EmployeeRepository;
        public EmployeeService(EmployeeRepository cRepo)
        {
            EmployeeRepository = cRepo;
        }

        public void Create(Employee entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Name) || string.IsNullOrWhiteSpace(entity.Surname))
            {
                throw new ArgumentException("Çalışan adı veya soyadı boş olamaz.");
            }
            EmployeeRepository.Add(entity);
        }

        public void Delete(int Id)
        {
            try
            {
                var Employee = EmployeeRepository.GetById(Id);
                if (Employee == null)
                {
                    throw new KeyNotFoundException("Çalışan bulunamadı.");
                }
                EmployeeRepository.Delete(Employee);
            }
            catch (Exception ex)
            {
                // Loglama yapılabilir
                throw new ApplicationException("Çalışan silme işlemi sırasında bir hata oluştu.", ex);
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            return EmployeeRepository.GetAll();
        }

        public Employee GetById(int Id)
        {
            return (EmployeeRepository.GetById(Id));
        }

        public void Update(Employee entity)
        {
            EmployeeRepository.Update(entity);
        }
    }
}
