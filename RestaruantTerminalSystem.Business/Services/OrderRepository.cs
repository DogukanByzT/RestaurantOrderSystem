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
    public class OrderService : IService<Order>
    {
        private readonly OrderRepository OrderRepository;
        public OrderService(OrderRepository cRepo)
        {
            OrderRepository = cRepo;
        }

        public void Create(Order entity)
        {
            OrderRepository.Add(entity);
        }

        public void Delete(int Id)
        {
            try
            {
                var Order = OrderRepository.GetById(Id);
                if (Order == null)
                {
                    throw new KeyNotFoundException("Sipariş bulunamadı.");
                }
                OrderRepository.Delete(Order);
            }
            catch (Exception ex)
            {
                // Loglama yapılabilir
                throw new ApplicationException("Sipariş silme işlemi sırasında bir hata oluştu.", ex);
            }
        }

        public IEnumerable<Order> GetAll()
        {
            return OrderRepository.GetAll();
        }

        public Order GetById(int Id)
        {
            return (OrderRepository.GetById(Id));
        }

        public void Update(Order entity)
        {
            OrderRepository.Update(entity);
        }
    }
}
