using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

            Store store = new Store("BA", "addr", "1121", "Baibai", "123");

            //welcome message
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("------- WELCOME TO BA CAKE SHOP MANAGEMENT APPLICATION -------");
            Console.WriteLine("--------------------------------------------------------------");

            store.DisplayCakeStoreDitails("BA Cake Shop", "Sweeties street", "5201314");

            Console.WriteLine("******************** Please Log In The App ********************");
            Console.WriteLine();

            //Declare the Manager List
            List<Manager> managers = new List<Manager>();

            Manager Bai = new Manager("Bai", 001, "bai123");
            Manager Amy = new Manager("Amy", 002, "amy123");

            managers.Add(Bai);
            managers.Add(Amy);

            //Call loginmanager method
            LoginPage.IdentityCheck(managers);
            AppSelectionMenu(store, managers);
        }
        public static void AppSelectionMenu(Store store, List<Manager> managers)
        {
            var exitSystem = false;
            //List<Cake> Cakes = new List<Cake>();


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

                        ManagerManagement managerManagement = new ManagerManagement();
                        managerManagement.AddNewManager(managers);
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Removing a manager");
                        ManagerManagement manageropeartion = new ManagerManagement();
                        manageropeartion.DeleteManager(managers);
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("You will Add a new Cake.");
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine("Please enter the cake name");
                        var cakeName = Console.ReadLine();
                        Console.WriteLine("Please enter the cake Price");
                        var cakePrice = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the cake ID");
                        var cakeId = Convert.ToInt32(Console.ReadLine());
                        if (store.IsCakeIdUsed(cakeId))
                        {
                            Console.WriteLine("Please press a key to return");
                            Console.ReadKey();
                            break;
                        }

                        store.AddCake(cakeName, cakePrice, cakeId);

                        foreach (Cake cakeN in store.Cakes)
                        {
                            cakeN.DisplayCakeDetailes();

                        }
                        Console.WriteLine($"This {cakeName} cake has been added, the price is {cakePrice}, the ID is {cakeId}");
                        Console.WriteLine("Press a key return to main menu.");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case "4":

                        Console.WriteLine("You will Remove an existing cake and Display the Detail Again");
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine("Please enter the ID of the existing cake");
                        int idCakeRemove = Convert.ToInt32(Console.ReadLine());

                        Cake removeCake = store.Cakes.Find(c => c.Id == idCakeRemove);

                        if (removeCake != null)
                        {
                            Console.WriteLine($"{idCakeRemove} found in the list");
                            store.Cakes.Remove(removeCake);
                            Console.WriteLine($"This ID {idCakeRemove} of cake has been removed for the list ");
                        }
                        else
                        {
                            Console.WriteLine($"This {removeCake} cake you want remove can not found!");
                            Console.WriteLine("Please press a key to return");
                            Console.ReadKey();
                            break;
                        }

                        store.DisplayCakes();
                        break;

                    case "5":
                        
                        Console.WriteLine("Please enter the ID of the cake which you want add a writing message.");
                        int idAddWritingCake= Convert.ToInt32(Console.ReadLine());
                        Cake addWritingCake = store.Cakes.Find(c => c.Id == idAddWritingCake);
                       
                        if (addWritingCake != null) 
                        {
                            Console.WriteLine($"The ID {idAddWritingCake} cake was founded");
                            Console.WriteLine("Please enter the custmer name");
                            var customerName = Console.ReadLine();
                            Console.WriteLine("Please enter the message");
                            var message = Console.ReadLine();
                            addWritingCake.WriteMessageOnCake(customerName, message);
                            addWritingCake.DisplayCakeDetailes();

                        }
                        else
                        {
                            Console.WriteLine($"The ID {idAddWritingCake} of cake can not found!");
                            Console.WriteLine("Please press a key to return");
                            Console.ReadKey();
                            break;
                        }
                        break;

                    case "6":

                        Console.WriteLine("You will Add a new Drink and then Display the Details Again");
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine("Please enter the drink name");
                        var drinkName = Console.ReadLine();
                        Console.WriteLine("Please enter the drink Price");
                        var drinkPrice = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the drink ID");
                        var drinkId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the capacity of the drink.");
                        var drinkCapacity = Console.ReadLine();

                        store.AddDrink(drinkName, drinkPrice, drinkId, drinkCapacity);

                        foreach (Drink drinkN in store.Drinks)
                        {
                            drinkN.DisplayDrinkDetails();

                        }
                        Console.WriteLine($"This {drinkName} drink has been added, the price is {drinkPrice}, the capacity is {drinkCapacity}, the ID is {drinkId}");
                        break;

                    case "7":


                        Console.WriteLine("You will Remove an existing drink and Display the Detail Again");
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine("Please enter the ID of the existing drink");
                        int idDrinkRemove = Convert.ToInt32(Console.ReadLine());

                        Drink removeDrink = store.Drinks.Find(d => d.Id == idDrinkRemove);

                        if (removeDrink != null)
                        {
                            Console.WriteLine($"{idDrinkRemove} found in the list");
                            store.Drinks.Remove(removeDrink);
                        }
                        else
                        {
                            Console.WriteLine($"This {removeDrink} drink you want remove can not found!");

                        }

                        store.DisplayDrinks();
                        break;

                    case "8":
                        Console.WriteLine("Please Enter the custmer name ");
                        string custmerName = Console.ReadLine();
                        store.SearchCakeByCustomerName(custmerName);
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
