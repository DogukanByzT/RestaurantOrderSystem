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
    public class ProductService : IService<Product>
    {
        private readonly ProductRepository ProductRepository;
        public ProductService(ProductRepository cRepo)
        {
            ProductRepository = cRepo;
        }

        public void Create(Product entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Name))
            {
                throw new ArgumentException("Ürün adı boş olamaz.");
            }
            ProductRepository.Add(entity);
        }

        public void Delete(int Id)
        {
            try
            {
                var Product = ProductRepository.GetById(Id);
                if (Product == null)
                {
                    throw new KeyNotFoundException("Ürün bulunamadı.");
                }
                ProductRepository.Delete(Product);
            }
            catch (Exception ex)
            {
                // Loglama yapılabilir
                throw new ApplicationException("Ürün silme işlemi sırasında bir hata oluştu.", ex);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            return ProductRepository.GetAll();
        }

        public Product GetById(int Id)
        {
            return (ProductRepository.GetById(Id));
        }

        public void Update(Product entity)
        {
            ProductRepository.Update(entity);
        }
    }
}
