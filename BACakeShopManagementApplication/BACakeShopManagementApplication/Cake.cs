using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BACakeShopManagementApplication
{
    internal class Cake: Item
    {
        public string CustmorName { get; set; }
        public string Message { get; set; } 
        
        const double WritingMessageFee = 5;
        

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
            Price += WritingMessageFee;
        }
        
        public void DisplayCakeDetailes()
        {
            Console.WriteLine($"Cake Name: \t\t{Name}\nCake Price: \t\t${Price}\nCake ID: \t\t{Id}\nCustmer Name: \t\t{CustmorName}\nWriting Message: \t{Message}\nThe extra price is: \t{WritingMessageFee}\n");
        }

        

       
    }
}
