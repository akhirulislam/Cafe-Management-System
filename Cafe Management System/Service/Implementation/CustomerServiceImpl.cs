using Cafe_Management_System.DB_Connection;
using Cafe_Management_System.Model;
using Cafe_Management_System.Service.Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cafe_Management_System.Service.Implementation
{
    internal class CustomerServiceImpl : ICustomerService
    {
        public List<Customer> getAllCustomerInfo()
        {
            string query = "SELECT * FROM customer";
            List<Customer> customers = new List<Customer>();

            try
            {
                if (DbConnection.connection == null || DbConnection.connection.State != System.Data.ConnectionState.Open)
                {
                    DbConnection.connection.Open();
                }

                MySqlCommand command = new MySqlCommand(query, DbConnection.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string customerName = reader.GetString(0);
                    string customerPhone = reader.GetString(1);

                    Customer customer = new Customer();
                    customer.CustomerName = customerName;
                    customer.CustomerPhone = customerPhone;

                    customers.Add(customer);
                }
                reader.Close();
                return customers;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public bool Login(string customerPhone,string password)
        {
                     
            try
            {
                string query = "SELECT * FROM customer";

                MySqlCommand statement = new MySqlCommand(query, DbConnection.connection);

                MySqlDataReader rs = statement.ExecuteReader();

                while (rs.Read())
                {
                    if (customerPhone.Equals(rs["customerPhone"].ToString()) && password.Equals(rs["password"].ToString()))
                    {
                        rs.Close();
                        return true;
                    }
                }

                rs.Close();
                return false;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("SQL Exception: " + e.Message);
            }
            return false;
        }

        public bool signUp(string customerName, string customerPhone, string password)
        {
            string query = "INSERT INTO customer(customerName, customerPhone, password) " +
                "VALUES(@customerName, @customerPhone, @password)";

            try
            {
                if (DbConnection.connection == null || DbConnection.connection.State != System.Data.ConnectionState.Open)
                {
                    DbConnection.connection.Open();
                }

                MySqlCommand command = new MySqlCommand(query, DbConnection.connection);

                command.Parameters.AddWithValue("@customerName", customerName);
                command.Parameters.AddWithValue("@customerPhone", customerPhone);
                command.Parameters.AddWithValue("@password", password);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
        }
    }
}
