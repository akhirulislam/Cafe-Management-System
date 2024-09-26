using Cafe_Management_System.DB_Connection;
using Cafe_Management_System.Model;
using Cafe_Management_System.Service.Interface;
using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System.Service.Implementation
{
    internal class EmployeeServiceImpl : IEmployeeService
    {
        public bool addEmployee(long id, string name, int age, string gender, string date,
            int sal, string post)
        {
            Employee employee = new Employee();
            employee.Id = id;
            employee.Name = name;
            employee.Age = age;
            employee.Gender = gender;
            employee.JoinDate = date;
            employee.Salary = sal;
            employee.Post = post;

            string query = "INSERT INTO employees(empId, empName, empAge, empGender,empSalary, Post , hireDate) " +
                "VALUES(@id, @name, @age, @gender, @sal, @post, @hireDate)";

            try
            {
                if (DbConnection.connection == null || DbConnection.connection.State != System.Data.ConnectionState.Open)
                {
                    DbConnection.connection.Open();
                }

                MySqlCommand command = new MySqlCommand(query, DbConnection.connection);

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@hireDate", date);
                command.Parameters.AddWithValue("@sal", sal);
                command.Parameters.AddWithValue("@post", post);

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

        public bool deleteEmployee(long id)
        {
            string query = "DELETE FROM employees WHERE empId = @empId";

            try
            {
                if (DbConnection.connection == null || DbConnection.connection.State != System.Data.ConnectionState.Open)
                {
                    DbConnection.connection.Open();
                }
                MySqlCommand command = new MySqlCommand(query, DbConnection.connection);
                command.Parameters.AddWithValue("@empId", id);
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

        public List<Employee> getAllEmpInfo()
        {
            string query = "SELECT * FROM employees";
            List<Employee> employees = new List<Employee>();

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
                    long id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    int age = reader.GetInt32(2);
                    string gender = reader.GetString(3);
                    string date = reader.GetString(6);
                    int sal = reader.GetInt32(4);
                    string post = reader.GetString(5);

                    Employee employee = new Employee();
                    employee.Id = id;
                    employee.Name = name;
                    employee.Age = age;
                    employee.Gender = gender;
                    employee.JoinDate = date;
                    employee.Salary = sal;
                    employee.Post = post;

                    employees.Add(employee);
                }
                reader.Close();
                return employees;               
            }catch(Exception e) {
                MessageBox.Show(e.Message);
                return null;
            }        
        }

        public Employee getEmpInfo(long empId)
        {
            string query = "SELECT * FROM employees WHERE empId=@empId";
            Employee employee = new Employee();
            
            try
            {
                if (DbConnection.connection == null || DbConnection.connection.State != System.Data.ConnectionState.Open)
                {
                    DbConnection.connection.Open();
                }

                MySqlCommand command = new MySqlCommand(query, DbConnection.connection);
                command.Parameters.AddWithValue("@empId", empId);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string name = reader.GetString(1);
                    string id = reader.GetInt64(0).ToString();
                    string age = reader.GetInt64(2).ToString();
                    string gender = reader.GetString(3);
                    string date = reader.GetString(6);
                    string sal = reader.GetInt64(4).ToString();
                    string post = reader.GetString(5);

                    employee.Id = empId;
                    employee.Name = name;
                    employee.Age = int.Parse(age);
                    employee.Gender = gender;
                    employee.JoinDate = date;
                    employee.Salary = int.Parse(sal);
                    employee.Post = post;
                }
                reader.Close();
                return employee;
            }
            catch (Exception ex)
            {
                return null;
            }           
        }

        public bool grantRole(long id)
        {
            throw new NotImplementedException();
        }

        public bool updateEmployee(long id, string name, int age, string gender, string date, int sal, string post)
        {
            var employeeInfo = getEmpInfo(id);
            if (employeeInfo == null)
            {               
                return false;
            }

            string updateQuery = "UPDATE employees SET empName=@empName, empAge=@empAge, empGender=@empGender, hireDate=@hireDate, empSalary=@empSalary, post=@empPost WHERE empId=@empId";

            try
            {
                if (DbConnection.connection == null || DbConnection.connection.State != System.Data.ConnectionState.Open)
                {
                    DbConnection.connection.Open();
                }

                MySqlCommand updateCommand = new MySqlCommand(updateQuery, DbConnection.connection);
                updateCommand.Parameters.AddWithValue("@empId", id);
                updateCommand.Parameters.AddWithValue("@empName", name);
                updateCommand.Parameters.AddWithValue("@empAge", age);
                updateCommand.Parameters.AddWithValue("@empGender", gender);
                updateCommand.Parameters.AddWithValue("@hireDate", date);
                updateCommand.Parameters.AddWithValue("@empSalary", sal);
                updateCommand.Parameters.AddWithValue("@empPost", post);

                int result = updateCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return false;
            }
            return false;
        }
    }
}
