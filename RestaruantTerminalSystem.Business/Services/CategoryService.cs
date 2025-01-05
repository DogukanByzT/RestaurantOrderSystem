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
    public class CategoryService : IService<Category>
    {
        private readonly CategoryRepository categoryRepository;
        public CategoryService(CategoryRepository cRepo)
        {
            categoryRepository = cRepo;
        }

        public void Create(Category entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Name))
            {
                throw new ArgumentException("Kategori adı boş olamaz.");
            }
            categoryRepository.Add(entity);
        }

        public void Delete(int Id)
        {
            try
            {
                var category = categoryRepository.GetById(Id);
                if (category == null)
                {
                    throw new KeyNotFoundException("Kategori bulunamadı.");
                }
                categoryRepository.Delete(category);
            }
            catch (Exception ex)
            {
                // Loglama yapılabilir
                throw new ApplicationException("Kategori silme işlemi sırasında bir hata oluştu.", ex);
            }
        }

        public IEnumerable<Category> GetAll()
        {
            return categoryRepository.GetAll();
        }

        public Category GetById(int Id)
        {
            return (categoryRepository.GetById(Id));
        }

        public void Update(Category entity)
        {
            categoryRepository.Update(entity);
        }
    }
}
