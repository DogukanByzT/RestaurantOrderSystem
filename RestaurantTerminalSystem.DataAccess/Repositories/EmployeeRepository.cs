using RestaurantTerminalSystem.DataAccess.Context;
using RestaurantTerminalSystem.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTerminalSystem.DataAccess.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>
    {
        public EmployeeRepository(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}
