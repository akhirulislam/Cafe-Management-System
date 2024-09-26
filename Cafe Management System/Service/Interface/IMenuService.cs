using Cafe_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System.Service.Interface
{
    internal interface IMenuService
    {

        public bool addItem(string itemName, double itemPrice);
        public Menu getItem(string itemName);

        public bool updateItem(string itemName, double itemPrice);

        public bool deleteItem(string itemName);

        public List<Menu> getAllItemInfo();
    }
}
