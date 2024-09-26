using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System.Model
{
    internal class Admin
    {
        private long id;
        private string userName;
        private string password;
        private string email;


        public Admin() { } 
        public Admin(long id, string userName, string email, string password)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
        }
     
        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
