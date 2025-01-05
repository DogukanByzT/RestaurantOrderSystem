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
    public class OrderDetailService : IService<OrderDetail>
    {
        private readonly OrderDetailRepository OrderDetailRepository;
        public OrderDetailService(OrderDetailRepository cRepo)
        {
            OrderDetailRepository = cRepo;
        }

        public void Create(OrderDetail entity)
        {
            
            OrderDetailRepository.Add(entity);
        }

        public void Delete(int Id)
        {
            try
            {
                var OrderDetail = OrderDetailRepository.GetById(Id);
                if (OrderDetail == null)
                {
                    throw new KeyNotFoundException("Sipariş bulunamadı.");
                }
                OrderDetailRepository.Delete(OrderDetail);
            }
            catch (Exception ex)
            {
                // Loglama yapılabilir
                throw new ApplicationException("Sipariş silme işlemi sırasında bir hata oluştu.", ex);
            }
        }

        public IEnumerable<OrderDetail> GetAll()
        {
            return OrderDetailRepository.GetAll();
        }

        public OrderDetail GetById(int Id)
        {
            return (OrderDetailRepository.GetById(Id));
        }

        public void Update(OrderDetail entity)
        {
            OrderDetailRepository.Update(entity);
        }
    }
}
