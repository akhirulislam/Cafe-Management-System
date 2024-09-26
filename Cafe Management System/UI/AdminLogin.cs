using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Cafe_Management_System.DB_Connection;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafe_Management_System.Service.Implementation;

namespace Cafe_Management_System.UI
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homePage homePage = new homePage();
            homePage.Show();
            this.Hide();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Username")
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter Password")
            {
                textBox2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminDashboard admin = new adminDashboard();
            try
            {
                var connection = DbConnection.connection;
                AdminServiceImpl login = new AdminServiceImpl();               

                if (login.Login(textBox1.Text, textBox2.Text))
                {
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            
        }
    }
}
