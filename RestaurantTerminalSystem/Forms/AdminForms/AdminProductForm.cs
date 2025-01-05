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
    public partial class AdminProductForm : BaseForm
    {
        private readonly ApplicationDbContext _context;
        private readonly ProductRepository _repository;
        private readonly ProductService _service;
        public AdminProductForm()
        {
            _context = new ApplicationDbContext();
            _repository = new ProductRepository(_context);
            _service = new ProductService(_repository);
            InitializeComponent();
            GetCategories();
        }

        private void GetCategories()
        {
            var list = _context.Categories.ToList();
            foreach (var category in list)
            {
                cmbCategories.Items.Add(category);
            }


        }

        private void AdminProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPicture.Text = openFileDialog1.FileName;
            }
            pictureBox1.Load(txtPicture.Text);
            byte[] imageBytes = File.ReadAllBytes(txtPicture.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = File.ReadAllBytes(txtPicture.Text);
            var value = (Category)cmbCategories.SelectedItem;

            Product product = new Product()
            {
                Name = txtProductName.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
                Category = value,
                Image = imageBytes,
            };
            _service.Create(product);
            _context.SaveChanges();
            GetList();
        }

        private void GetList()
        {
            lstList.Items.Clear();
            var list = _context.Products.ToList();
            foreach (var item in list)
            {
                lstList.Items.Add(item);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var value = (Product)lstList.SelectedItem;
            if (value != null)
            {
                _service.Delete(value.Id);
            }
            else
            {
                MessageBox.Show("Lütfen Bir Ürün Seçin");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            GetList();
        }
    }
}
