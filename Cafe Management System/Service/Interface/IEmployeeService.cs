using Cafe_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cafe_Management_System.Service.Interface
{
    internal interface IEmployeeService
    {
        public bool addEmployee(long id, string name, int age, string gender, string date, int sal, string post);
        public Employee getEmpInfo(long id);

        public bool updateEmployee(long id, string name, int age, string gender, string date, int sal, string post);

        public bool deleteEmployee(long id);

        public List<Employee> getAllEmpInfo();

        public bool grantRole(long id);
    }
}
