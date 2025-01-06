using Microsoft.EntityFrameworkCore;
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
    public partial class AdminEmployeeForm : BaseForm
    {
        private readonly ApplicationDbContext context;
        private readonly EmployeeRepository employeeRepository;
        private readonly EmployeeService employeeService;
        public AdminEmployeeForm()
        {
            context = new ApplicationDbContext();
            employeeRepository = new EmployeeRepository(context);
            employeeService = new EmployeeService(employeeRepository);
            InitializeComponent();
        }

        private void AdminEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee()
                {
                    Name = txtEmployeeName.Text,
                    Surname = txtEmployeeSurname.Text,
                    Position = txtPosition.Text,
                    Password = txtPassword.Text,
                };

                employeeService.Create(employee);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir sorun meydana geldi {ex.Message}");

            }
            GetList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var value = (Employee)lstList.SelectedItem;
            employeeService.Delete(value.Id);
            context.SaveChanges();
            GetList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void GetList()
        {
            lstList.Items.Clear();
            var list = context.Employees.ToList();
            foreach (var item in list)
            {
                lstList.Items.Add(item);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var value = (Employee)lstList.SelectedItem;

                value.Name = txtEmployeeName.Text;
                value.Surname = txtEmployeeSurname.Text;
                value.Position = txtPosition.Text;
                value.Password = txtPassword.Text;
                employeeService.Update(value);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
       
        }
    }
}
