using Cafe_Management_System.Model;
using Cafe_Management_System.Service.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.UI
{
    public partial class ShowAllEmployee : Form
    {
        private EmployeeServiceImpl employeeService;
        public ShowAllEmployee()
        {
            InitializeComponent();
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            try
            {
                employeeService = new EmployeeServiceImpl();
                List<Employee> employeeData = employeeService.getAllEmpInfo();

                if (employeeData != null)
                {                   
                    for (int i = 0; i < employeeData.Count; i++)
                    {
                        Employee emp = employeeData[i];
                        long id = emp.Id;
                        string name = emp.Name;
                        int age = emp.Age;
                        string gender = emp.Gender;
                        string date = emp.JoinDate;
                        int sal = emp.Salary;
                        string post = emp.Post;

                        dataGridView1.Rows.Add(id.ToString(), name, age.ToString(), gender, sal.ToString(), post, date);
                    }
                }
                else
                {
                    MessageBox.Show("No employee data available.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
