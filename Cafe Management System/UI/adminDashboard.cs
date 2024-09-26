using Cafe_Management_System.DB_Connection;
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
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmpManagement empManagement = new EmpManagement();
            empManagement.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateRole updateRole = new UpdateRole();
            updateRole.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowAllCustomerInfo showAllCustomerInfo = new ShowAllCustomerInfo();
            showAllCustomerInfo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemManagment itemManagment = new ItemManagment();
            itemManagment.Show();
        }
    }
}
