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

namespace Cafe_Management_System
{
    public partial class Place_Order : Form
    {
        private CustomerServiceImpl customerService;
        private MenuServiceImpl menuService;
        public Place_Order()
        {
            InitializeComponent();
            loadGridView();
            dataGridView2.Rows.Clear();
            textBox4.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadGridView();
        }
        private void loadGridView()
        {
            try
            {
                dataGridView1.Rows.Clear();
                menuService = new MenuServiceImpl();
                List<Menu> menuData = menuService.getAllItemInfo();

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

        private void button2_Click(object sender, EventArgs e)
        {
            string itemName = textBox1.Text;
            if (!string.IsNullOrEmpty(itemName))
            {
                Menu item = menuService.getItem(itemName);

                if (item != null)
                {
                    double itemPrice = item.ItemPrice;
                    int quantity = int.Parse(comboBox2.Text);
                    double currentTotal = itemPrice * quantity;

                    dataGridView2.Rows.Add(itemName, currentTotal, quantity);

                    double grandTotal = 0;
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows[i].Cells[1].Value != null)
                        {
                            grandTotal += Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value);
                        }
                    }

                    textBox4.Text = grandTotal.ToString() + " Taka";
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            float rowHeight = 30;

            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                e.Graphics.DrawString(dataGridView2.Columns[i].HeaderText, font, Brushes.Black, x, y);
                x += dataGridView2.Columns[i].Width;
            }

            y += rowHeight;
            x = e.MarginBounds.Left;

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                    {
                        e.Graphics.DrawString(dataGridView2.Rows[i].Cells[j].Value.ToString(), font, Brushes.Black, x, y);
                    }
                    x += dataGridView2.Columns[j].Width;
                }
                y += rowHeight;
                x = e.MarginBounds.Left;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string orderName = "Order_" + ".pdf";
            string filePath = @"C:\Users\Public\Downloads\" + orderName;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            printDocument1.PrinterSettings.PrintToFile = true;
            printDocument1.PrinterSettings.PrintFileName = filePath;

            string printerName = "Microsoft Print to PDF";
            printDocument1.PrinterSettings.PrinterName = printerName;

            printDocument1.Print();

            textBox1.Clear();
            dataGridView2.Rows.Clear();
        }
    }
}

