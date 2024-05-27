using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

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

        public Cake(string cakeName, double cakePrice, int cakeId, string customerName, string message)
        {
            Name = cakeName;
            Price = cakePrice;
            Id = cakeId;
            Message = message;
            CustmorName = customerName;
        }

       
        public void WriteMessageOnCake(string customerName, string message)
        {
            Message = message;
            CustmorName = customerName;
        }

        public void DisplayCakeDetailes()
        {
            Console.WriteLine($"Cake Name: \t{Name}\nCake Price: \t${Price}\nCake ID: \t{Id}\nCustmer Name: \t{CustmorName}\nWriting Message: \t{Message}\n");
        }

        

       
    }
}
