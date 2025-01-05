using RestaurantTerminalSystem.DataAccess.Context;
using RestaurantTerminalSystem.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTerminalSystem.DataAccess.Repositories
{
    public class OrderRepository : GenericRepository<Order>
    {
        public OrderRepository(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}
