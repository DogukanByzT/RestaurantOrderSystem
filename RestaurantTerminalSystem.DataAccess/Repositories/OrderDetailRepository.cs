using RestaurantTerminalSystem.DataAccess.Context;
using RestaurantTerminalSystem.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTerminalSystem.DataAccess.Repositories
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>
    {
        public OrderDetailRepository(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}
