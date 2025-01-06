using RestaurantTerminalSystem.UI.Forms.AdminForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantTerminalSystem.UI.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }


        private void btnAdminCategories_Click(object sender, EventArgs e)
        {
            AdminCategories form = new AdminCategories();
            ShowForm(form);
        }
        public void ShowForm(Form form)
        {
            pnlForm.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlForm.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminProductForm form = new AdminProductForm();
            ShowForm(form);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminEmployeeForm form = new AdminEmployeeForm();
            ShowForm(form);
        }
    }
}
