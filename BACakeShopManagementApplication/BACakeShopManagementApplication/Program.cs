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
        private static object cakeRemove;

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
            //TODO: -99. Exit


            var store = new Store("BA", "addr", "1121", "Baibai", "123");

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("-------WELCOME TO BA CAKE SHOP MANAGEMENT APPLICATION-------");
            Console.WriteLine("------------------------------------------------------------");
            store.DisplayCakeStoreDitails("BA Bakery Store", "addr", "1121");

            var exitSystem = false;
            //List<Cake> cakes = new List<Cake>();

            
            //writeline menu items


            while (!exitSystem)
            {
                Console.WriteLine("Please select the operation: ");
                Console.WriteLine("1. Add Manager");
                Console.WriteLine("2. Remove Manager");
                Console.WriteLine("3. Add cake");
                Console.WriteLine("4. Remove cake");
                Console.WriteLine("5. Add writing on cake");
                Console.WriteLine("6. Add drink");
                Console.WriteLine("7. Remove drink");
                Console.WriteLine("8. Search Cake by custmer name");
                Console.WriteLine("99. Exit");                           

                string selectedAction = Console.ReadLine();

                switch (selectedAction)

                {
                    
                    case "1":
                        Console.WriteLine("Adding new manager");
                        //TODO: AddNewManager()
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Removing manager");
                        //TODO: RemoveManager()
                        break;

                    case "3":
                        Console.WriteLine("You will Add a new Cake and then Display the Details Again");
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine("Please enter the cake name");
                        var cakeName = Console.ReadLine();
                        Console.WriteLine("Please enter the cake Price");
                        var cakePrice = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the cake ID");
                        var cakeId = Convert.ToInt32(Console.ReadLine());

                        Cake newCake = new Cake(cakeName, cakePrice, cakeId);
                        store.cakes.Add(newCake);
                       
                        foreach (Cake cakeN in store.cakes)
                        {
                            cakeN.DisplayCakeDetailes();

                        }
                        Console.WriteLine($"This {cakeName} cake has been added, the price is {cakePrice}, the ID is {cakeId}");
                        //TODO: AddNewCake()
                        break;

                    case "4":

                        Console.WriteLine("You will Remove an existing cake and Display the Detail Again");
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine("Please enter the ID of the existing cake");
                        int idCakeRemove= Convert.ToInt32(Console.ReadLine());

                        Cake removeCake = store.cakes.Find(c => c.Id == idCakeRemove);

                        if (removeCake != null)
                        {
                            Console.WriteLine($"{idCakeRemove} found in the list");
                            store.cakes.Remove(removeCake);
                        }
                        else 
                        {
                            Console.WriteLine($"This {removeCake} cake you want remove can not found!");
                        
                        }

                        
                        store.DisplayCakes();
                       

                        //TODO: RemoveCake()
                        break;

                    case "5":
                        
                        Console.WriteLine("Adding writing on cake");
                        //TODO: AddWritingOnCake()
                        break;

                    case "6":
                        
                        Console.WriteLine("Adding new drink");
                        //TODO: AddNewDrink
                        break;

                    case "7":
                        
                        Console.WriteLine("Removing drink");
                        //TODO: RemoveDrink()
                        break;

                    case "8":
                        
                        Console.WriteLine("Search cake (by custmer name)");
                        //TODO: SearchCakeByUserName()
                        break;

                    case "99":
                        
                        Console.WriteLine("Exit");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Wrong choice.. Please try again");
                        break;

                }//end of switch
                    

            }//end of while



            

            






        }
    }
}
