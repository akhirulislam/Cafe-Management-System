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
    public partial class UpdateEmployee : Form
    {
        private EmployeeServiceImpl employeeService;
        public UpdateEmployee()
        {
            InitializeComponent();
            panel1.Hide();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            employeeService = new EmployeeServiceImpl();

            if (!long.TryParse(textBox4.Text, out long id))
            {
                MessageBox.Show("Invalid ID format!");
                return;
            }

            Employee employeeInfo = employeeService.getEmpInfo(id);
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
                        radioButton1.Select();
                    }
                    else if (string.Equals(gender, "Female", StringComparison.OrdinalIgnoreCase))
                    {
                        radioButton2.Select();
                    }
                    panel1.Show();
                    textBox4.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Employee not found!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            employeeService = new EmployeeServiceImpl();

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox4.Text) &&
                    !string.IsNullOrEmpty(comboBox2.Text) && (radioButton1.Checked || radioButton2.Checked) &&
                    dateTimePicker1.Value != null && !string.IsNullOrEmpty(textBox2.Text) &&
                    !string.IsNullOrEmpty(textBox3.Text))
            {
                long id = long.Parse(textBox4.Text);
                string name = textBox1.Text;
                int age = int.Parse(comboBox2.Text);
                string gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
                string joinDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                int salary = int.Parse(textBox2.Text);
                string post = textBox3.Text;

                if (employeeService.updateEmployee(id, name, age, gender, joinDate, salary, post))
                {
                    MessageBox.Show("Employee updated successfully!");
                    this.Hide();
                    EmpManagement empManagement = new EmpManagement();
                    empManagement.Show();
                }
                else
                {
                    MessageBox.Show("Failed to update employee. Try with unique Employee ID");
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields.");
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
