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
    public partial class EmpManagement : Form
    {
        public EmpManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateEmployee updateEmployee = new UpdateEmployee();
            updateEmployee.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveEmployee removeEmployee = new RemoveEmployee();
            removeEmployee.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchEmployee searchEmployee = new SearchEmployee();
            searchEmployee.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowAllEmployee showAllEmployee = new ShowAllEmployee();

            showAllEmployee.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminDashboard adminDashboard = new adminDashboard();
            adminDashboard.Show();
        }
    }
}
