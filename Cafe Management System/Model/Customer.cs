using System;

namespace Cafe_Management_System.Model
{
    internal class Customer
    {
        private string customerName;
        private string customerPhone;
        private string password;

        public Customer()
        {
        }

        public Customer(string customerName, string customerPhone, string password)
        {
            this.customerName = customerName;
            this.customerPhone = customerPhone;
            this.password = password;
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string CustomerPhone
        {
            get { return customerPhone; }
            set { customerPhone = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
