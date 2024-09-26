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
    public partial class SignUp : Form
    {
        private CustomerServiceImpl customerService;
        public SignUp()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            logInPage logInPage = new logInPage();
            logInPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text))
            {
                if (textBox3.Text != textBox4.Text)
                {
                    MessageBox.Show("Password didn't matched!");
                }
                else
                {
                    customerService = new CustomerServiceImpl();
                    string customerName = textBox1.Text;
                    string customerPhone = textBox2.Text;
                    string password = textBox3.Text;
                    if (customerService.signUp(customerName, customerPhone, password))
                    {
                        MessageBox.Show("Account created");
                        this.Hide();
                        logInPage logInPage = new logInPage();
                        logInPage.Show();
                    }
                    else
                    {
                        MessageBox.Show("This phone number is already registered.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Pleasse fill all the boxes");
            }

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter your name")
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter your phone number")
            {
                textBox2.Text = "";
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "password")
            {
                textBox4.Text = "";
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "password")
            {
                textBox3.Text = "";
            }
        }
    }
}
