using RestaruantTerminalSystem.Business.Services;
using RestaurantTerminalSystem.DataAccess.Context;
using RestaurantTerminalSystem.DataAccess.Repositories;
using RestaurantTerminalSystem.Entities.Entities;
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
    public partial class AdminCategories : BaseForm
    {
        private readonly ApplicationDbContext _context;
        private readonly CategoryRepository cRepo;
        private readonly CategoryService cService;

        public AdminCategories()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            cRepo = new CategoryRepository(_context);
            cService = new CategoryService(cRepo);
        }

        private void AdminCategories_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text != null)
            {
                Category category = new Category()
                {
                    Name = txtCategoryName.Text,
                };
                cService.Create(category);
                _context.SaveChanges();
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lstList.Items.Clear();
            try
            {
                var categories = cService.GetAll().ToList();
                foreach (var category in categories) { 
                lstList.Items.Add(category);
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
