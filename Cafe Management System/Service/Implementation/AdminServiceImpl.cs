using Cafe_Management_System.DB_Connection;
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

namespace Cafe_Management_System.Service.Implementation
{
    internal class AdminServiceImpl:IAdminService
    {
        private EmployeeServiceImpl employeeService;
        public bool addAdmin(long id,string userName, string email, string password)
        {                         
                string query = "INSERT INTO user_admin(adminId, userName, email, password) " +
                "VALUES(@id, @name, @email, @password)";

                try
                {
                    if (DbConnection.connection == null || DbConnection.connection.State != System.Data.ConnectionState.Open)
                    {
                        DbConnection.connection.Open();
                    }

                    MySqlCommand command = new MySqlCommand(query, DbConnection.connection);

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", userName);
                    command.Parameters.AddWithValue("@email", email);
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

        public bool Login(string userName, string pass)
        {
            try
            {
                if (DbConnection.connection == null || DbConnection.connection.State != System.Data.ConnectionState.Open)
                {
                    DbConnection.connection.Open();
                }

                string query = "SELECT * FROM user_admin";

                MySqlCommand statement = new MySqlCommand(query, DbConnection.connection);

                MySqlDataReader rs = statement.ExecuteReader();

                while (rs.Read())
                {
                    if (userName.Equals(rs.GetString(1)) && pass.Equals(rs.GetString(3)))
                    {
                        rs.Close();
                        return true;
                    }
                }

                rs.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("SQL Exception: " + e.Message);
            }
            return false;
        }

        public bool removeAdmin(long id)
        {
            string query = "DELETE FROM user_admin WHERE adminId = @id";

            try
            {
                if (DbConnection.connection == null || DbConnection.connection.State != System.Data.ConnectionState.Open)
                {
                    DbConnection.connection.Open();
                }
                MySqlCommand command = new MySqlCommand(query, DbConnection.connection);
                command.Parameters.AddWithValue("@id", id);
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
    }
}
