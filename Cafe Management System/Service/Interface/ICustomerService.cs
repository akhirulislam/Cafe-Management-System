using Cafe_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System.Service.Interface
{
    internal interface ICustomerService
    {
        public bool Login(string customerPhone,string password);

        public bool signUp(string customerName, string customerPhone, string password);

        public List<Customer> getAllCustomerInfo();
    }
}
