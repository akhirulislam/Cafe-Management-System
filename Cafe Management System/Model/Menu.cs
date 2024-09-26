using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System.Model
{
    internal class Menu
    {

        private string itemName;
        private double itemPrice;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public double ItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }
        public Menu()
        {

        }
        public Menu(string itemName, double itemPrice)
        {
            this.itemName = itemName;
            this.itemPrice = itemPrice;
        }
    }
}
