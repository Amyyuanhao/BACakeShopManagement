using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BACakeShopManagementApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Initialize the store object
            //TODO: Login 
            //TODO: Welcome Message
            //TODO: Menu skeleton
            //TODO:- 1. AddManager
            //TODO:- 2. RemoveManger
            //TODO:- 3. AddCake
            //TODO:- 4. RemoveCake
            //TODO:- 5. AddWritingMessageOnCake
            //TODO:- 6. AddDrink
            //TODO: -7. RemoveDrink
            //TODO: -8. SearchCakeByCustmerName
            //TODO: -0. Exit


            var store = new Store("BA", "addr", "1121", "Baibai", "123");

            Console.WriteLine("-------WELCOME TO BA CAKE SHOP MANAGEMENT APPLICATION-------");
            Console.WriteLine("------------------------------------------------------------");
            store.DisplayCakeStoreDitails("BA", "addr", "1121");


            //Console.WriteLine("Please enter the use name: ");
            //string useName = Console.ReadLine();

            //Console.WriteLine("Please enter the password:");
            //string passWord = Console.ReadLine();






        }
    }
}
