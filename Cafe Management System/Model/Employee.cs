using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System.Model
{
    internal class Employee
    {
        private long id;
        private string name;
        private int age;
        private string gender;
        private string joinDate;
        private int salary;
        private string post;

        public Employee() { }

        public Employee(long id, string name, int age, string gender, string joinDate, int salary, string post)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.joinDate = joinDate;
            this.salary = salary;
            this.post = post;
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string JoinDate { get; set; }
        public int Salary { get; set; }
        public string Post { get; set; }


    }
}
