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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Menu = Cafe_Management_System.Model.Menu;

namespace Cafe_Management_System.UI
{
    public partial class ItemManagment : Form
    {
        private MenuServiceImpl MenuServiceImpl;
        public ItemManagment()
        {
            InitializeComponent();
            panel1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuServiceImpl = new MenuServiceImpl();
            panel1.Show();
            label2.Show();
            textBox4.Show();
            dataGridView1.Rows.Clear();

            if (!string.IsNullOrEmpty(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox4.Text))
            {
                string itemName = textBox1.Text;
                double itemPrice = double.Parse(textBox4.Text);

                if (MenuServiceImpl.addItem(itemName, itemPrice))
                {
                    MessageBox.Show("Item added");
                    textBox1.Clear();
                    textBox4.Clear();
                    dataGridView1.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Error: Duplicate Item!");
                }
            }
        }

        private void loadGridView()
        {
            try
            {
                dataGridView1.Rows.Clear();
                MenuServiceImpl = new MenuServiceImpl();
                List<Menu> menuData = MenuServiceImpl.getAllItemInfo();

                if (menuData != null)
                {
                    for (int i = 0; i < menuData.Count; i++)
                    {
                        Menu item = menuData[i];
                        string itemName = item.ItemName;
                        string itemPrice = item.ItemPrice.ToString();

                        dataGridView1.Rows.Add(itemName, itemPrice);
                    }
                }
                else
                {
                    MessageBox.Show("No item data available.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Hide();
            textBox4.Hide();
            panel1.Show();
            dataGridView1.Rows.Clear();

            MenuServiceImpl = new MenuServiceImpl();

            if (MenuServiceImpl.deleteItem(textBox1.Text))
            {
                MessageBox.Show("Item removed successfully");
                textBox1.Clear();
                textBox4.Clear();
                loadGridView();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            loadGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuServiceImpl = new MenuServiceImpl();
            panel1.Show();
            label2.Show();
            textBox4.Show();
            dataGridView1.Rows.Clear();

            if (!string.IsNullOrEmpty(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox4.Text))
            {
                string itemName = textBox1.Text;
                double itemPrice = double.Parse(textBox4.Text);

                if (MenuServiceImpl.updateItem(itemName, itemPrice))
                {
                    MessageBox.Show("Item updated");
                    textBox1.Clear();
                    textBox4.Clear();
                    dataGridView1.Rows.Clear();
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminDashboard adminDashboard = new adminDashboard();
            adminDashboard.Show();
        }
    }
}
