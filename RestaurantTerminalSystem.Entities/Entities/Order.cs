using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTerminalSystem.Entities.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
        public decimal TotalAmount { get; set; }

        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
