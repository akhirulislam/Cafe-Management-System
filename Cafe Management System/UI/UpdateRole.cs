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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cafe_Management_System.UI
{
    public partial class UpdateRole : Form
    {
        private EmployeeServiceImpl employeeService;
        private AdminServiceImpl adminService;
        public UpdateRole()
        {
            InitializeComponent();
            panel1.Hide();
            panel2.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminDashboard adminDashboard = new adminDashboard();
            adminDashboard.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminService = new AdminServiceImpl();

            long id = long.Parse(textBox4.Text);
            string userName = textBox8.Text;
            string email = textBox6.Text;
            string password = textBox7.Text;

            if (adminService.addAdmin(id, userName, email, password))
            {
                MessageBox.Show("User role updated");
                panel2.Hide();
            }
            else
            {
                MessageBox.Show("This user has already admin role.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            adminService = new AdminServiceImpl();

            long id = long.Parse(textBox4.Text);

            if (adminService.removeAdmin(id))
            {
                MessageBox.Show("User removed from admin");
                panel2.Hide();
            }
            else
            {
                MessageBox.Show("This user has no role for admin");
            }
        }
    }
}
