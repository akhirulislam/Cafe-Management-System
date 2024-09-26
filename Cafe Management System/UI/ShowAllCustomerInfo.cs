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
    public partial class ShowAllCustomerInfo : Form
    {
        private CustomerServiceImpl customerService;
        public ShowAllCustomerInfo()
        {
            InitializeComponent();
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            try
            {
                customerService = new CustomerServiceImpl();
                List<Customer> customerData = customerService.getAllCustomerInfo();

                if (customerData != null)
                {
                    for (int i = 0; i < customerData.Count; i++)
                    {
                        Customer obj = customerData[i];
                        string customerName = obj.CustomerName;
                        string customerPhone = obj.CustomerPhone;

                        dataGridView1.Rows.Add(customerName.ToString(),customerPhone.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No customer data available.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
