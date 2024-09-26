using Cafe_Management_System.DB_Connection;
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
    public partial class logInPage : Form
    {
        private CustomerServiceImpl customerService;
        public logInPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage homePage = new homePage();
            homePage.Show();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Username")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Phone Number")
            {
                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            try
            {
                var connection = DbConnection.connection;
                customerService = new CustomerServiceImpl();
                
                

                    if (customerService.Login(textBox1.Text, textBox2.Text))
                    {
                        Place_Order place_Order = new Place_Order();
                        place_Order.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect phone number or password");
                        this.Show();
                    }
                             
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter Password")
            {
                textBox2.Text = "";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void textBox2_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter Password")
            {
                textBox2.Text = "";
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}
