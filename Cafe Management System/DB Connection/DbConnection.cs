using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Cafe_Management_System.DB_Connection
{
    internal class DbConnection
    {
        private static string url = "server=localhost;port=3306;database=cafemanagementsystem;";
        private static string id = "root";
        private static string pass = "";
        public static MySqlConnection connection;
        static DbConnection()
        {
            try
            {
                connection = new MySqlConnection($"{url}user={id};password={pass};");
                connection.Open();
                Console.WriteLine("Connected to the database successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to connect to the database!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
