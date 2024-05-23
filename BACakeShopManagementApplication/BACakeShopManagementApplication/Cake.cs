using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACakeShopManagementApplication
{
    internal class Cake: Item
    {
        public string CustmorName { get; set; }
        public string Message { get; set; }

        public Cake(string name, double price, int id)
        {
            Name = name;
            Price = price;
            Id = id;
        }

        public void WriteMessageOnCake(string custmorName,string message)
        {
            this.Message = message;
            this.CustmorName = custmorName;
        }

     
    }
}
