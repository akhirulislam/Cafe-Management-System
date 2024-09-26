using Cafe_Management_System.Model;
using Cafe_Management_System.Service.Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Cafe_Management_System.DB_Connection;
using Menu = Cafe_Management_System.Model.Menu;

namespace Cafe_Management_System.Service.Implementation
{
    internal class MenuServiceImpl : IMenuService
    {
        public bool addItem(string itemName, double itemPrice)
        {
            string query = "INSERT INTO menu(itemName, itemPrice) " +
                 "VALUES(@itemName, @itemPrice)";

            try
            {
                if (DbConnection.connection == null || DbConnection.connection.State != System.Data.ConnectionState.Open)
                {
                    DbConnection.connection.Open();
                }

                MySqlCommand command = new MySqlCommand(query, DbConnection.connection);

                command.Parameters.AddWithValue("@itemName", itemName);
                command.Parameters.AddWithValue("@itemPrice", itemPrice);
        
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

        public bool deleteItem(string itemName)
        {
            string query = "DELETE FROM menu WHERE itemName = @itemName";

            try
            {
                if (DbConnection.connection == null || DbConnection.connection.State != System.Data.ConnectionState.Open)
                {
                    DbConnection.connection.Open();
                }
                MySqlCommand command = new MySqlCommand(query, DbConnection.connection);
                command.Parameters.AddWithValue("@itemName", itemName);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<Menu> getAllItemInfo()
        {
            string query = "SELECT * FROM menu";
            List<Menu> items = new List<Menu>();

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
                    
                    string itemName = reader.GetString(0);
                    double itemPrice = reader.GetDouble(1);

                    Menu item = new Menu();
                    item.ItemName = itemName;
                    item.ItemPrice = itemPrice;

                    items.Add(item);
                }
                reader.Close();

                return items;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Menu getItem(string itemName)
        {
            string query = "SELECT * FROM menu WHERE itemName=@itemName";
            Menu item = new Menu();

            try
            {
                if (DbConnection.connection == null || DbConnection.connection.State != System.Data.ConnectionState.Open)
                {
                    DbConnection.connection.Open();
                }
                MySqlCommand command = new MySqlCommand(query, DbConnection.connection);

                command.Parameters.AddWithValue("@itemName", itemName);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    double itemPrice = reader.GetDouble(1);


                    item.ItemName = itemName;
                    item.ItemPrice = itemPrice;
                }
                reader.Close();

                return item;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool updateItem(string itemName, double itemPrice)
        {
            Menu itemInfo = getItem(itemName);
            if (itemInfo == null)
            {
                return false;
            }

            string updateQuery = "UPDATE menu SET itemName=@itemName, itemPrice=@itemPrice WHERE itemName=@itemName";

            try
            {
                if (DbConnection.connection == null || DbConnection.connection.State != System.Data.ConnectionState.Open)
                {
                    DbConnection.connection.Open();
                }

                MySqlCommand updateCommand = new MySqlCommand(updateQuery, DbConnection.connection);

                updateCommand.Parameters.AddWithValue("@itemName", itemName);
                updateCommand.Parameters.AddWithValue("@itemPrice", itemPrice);
               

                int result = updateCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return false;
        }


    }
}
