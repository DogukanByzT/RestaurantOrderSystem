using RestaruantTerminalSystem.Business.Services;
using RestaurantTerminalSystem.DataAccess.Context;
using RestaurantTerminalSystem.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantTerminalSystem.UI.Forms.AdminForms
{
    public partial class AdminOrderForm : BaseForm
    {
        private readonly ApplicationDbContext _context;
        private readonly OrderRepository orderRepository;
        private readonly OrderService orderService;
        public AdminOrderForm()
        {
            _context = new ApplicationDbContext();
            orderRepository = new OrderRepository(_context);
            orderService = new OrderService(orderRepository);
            InitializeComponent();
        }
        private void LoadOrders()
        {
            var orders = orderService.GetAll();
            dgvOrder.DataSource = orders.Select(o => new
            {
                o.Id,
                o.OrderDate,
                EmployeeName = o.Employee != null ? o.Employee.Name : "N/A",
                o.TotalAmount
            }).ToList();
        }
        private void AdminOrderForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}
