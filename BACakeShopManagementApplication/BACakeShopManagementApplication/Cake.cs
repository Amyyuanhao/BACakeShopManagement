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

        public Cake(string cakeName, double cakePrice, int cakeId)
        {
            Name = cakeName;
            Price =cakePrice;
            Id = cakeId;
        }


        public void WriteMessageOnCake(string custmorName,string message)
        {
            this.Message = message;
            this.CustmorName = custmorName;
        }

        public void DisplayCakeDetailes()
        {
            Console.WriteLine($"Cake Name: \t{Name}\nCake Price: \t{Price}\nCake ID: \t{Id}\n");
        }

       
    }
}
