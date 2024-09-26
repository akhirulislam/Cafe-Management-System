using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System.Service.Interface
{
    internal interface IAdminService
    {
        public bool Login(string userName, string pass);
        public bool addAdmin(long id, string userName, string email, string password);
        public bool removeAdmin(long id);

    }
}
