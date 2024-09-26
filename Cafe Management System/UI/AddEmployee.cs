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
    public partial class AddEmployee : Form
    {
        private EmployeeServiceImpl employeeService;
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmpManagement empManagement = new EmpManagement();
            empManagement.Show();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(textBox4.Text, out long empId))
            {
                MessageBox.Show("Invalid ID format!");
                return;
            }

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox4.Text) &&
                !string.IsNullOrEmpty(comboBox2.Text) && (radioButton1.Checked || radioButton2.Checked) &&
                dateTimePicker1.Value != null && !string.IsNullOrEmpty(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text))
            {               
                long id = long.Parse(textBox4.Text);
                string name = textBox1.Text;
                int age = int.Parse(comboBox2.Text);
                string gender;
                if (radioButton1.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string joinDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                int salary = int.Parse(textBox2.Text);
                string post = textBox3.Text;

                employeeService = new EmployeeServiceImpl();

                if (employeeService.addEmployee(id, name, age, gender, joinDate, salary, post))
                {
                    MessageBox.Show("Employee added successfully!");
                    this.Hide();
                    EmpManagement empManagement = new EmpManagement();
                    empManagement.Show();
                }
                else
                {
                    MessageBox.Show("Failed to add employee. Try with unique Employee ID");
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields.");
            }
        }
    }
}
