using Cafe_Management_System.Model;
using Cafe_Management_System.Service.Implementation;
using Cafe_Management_System.Service.Interface;
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
    public partial class SearchEmployee : Form
    {
       
        private EmployeeServiceImpl EmployeeServiceImpl;
        public SearchEmployee()
        {
            InitializeComponent();
            panel1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeServiceImpl = new EmployeeServiceImpl();
            if (!long.TryParse(textBox4.Text, out long id))
            {
                MessageBox.Show("Invalid ID format!");
                return;
            }
            Employee employeeInfo = EmployeeServiceImpl.getEmpInfo(id);
            try
            {
                if (employeeInfo != null)
                {
                    string name = employeeInfo.Name;
                    long empId = employeeInfo.Id;
                    int age = employeeInfo.Age;
                    string gender = employeeInfo.Gender;
                    string date = employeeInfo.JoinDate;
                    int sal = employeeInfo.Salary;
                    string post = employeeInfo.Post;

                    textBox1.Text = name;
                    textBox2.Text = sal.ToString();
                    textBox3.Text = post;

                    dateTimePicker1.Text = date;
                    comboBox2.Text = age.ToString();
                    if (string.Equals(gender, "Male", StringComparison.OrdinalIgnoreCase))
                    {
                        textBox5.Text = gender;
                    }
                    else if (string.Equals(gender, "Female", StringComparison.OrdinalIgnoreCase))
                    {
                        textBox5.Text = gender;
                    }
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox5.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    comboBox2.Enabled = false;
                    
                    panel1.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Employee not found!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmpManagement empManagement = new EmpManagement();
            empManagement.Show();
        }
    }
}
