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
        static void Main(string[] args)
        {
            Store store = new Store("BA", "addr", "1121");
            initStore(store);
            //welcome message
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("------- WELCOME TO BA CAKE SHOP MANAGEMENT APPLICATION -------");
            Console.WriteLine("--------------------------------------------------------------");

            store.DisplayCakeStoreDitails("BA Cake Shop", "Sweeties street", "5201314");

           



            //Call loginmanager method
            //LoginPage.IdentityCheck(store.Managers);
            AppSelectionMenu(store);
        }
        private static void initStore(Store store)
        {
            //Declare Manager List
            Manager Bai = new Manager("Bai", 1, "bai123");
            Manager Amy = new Manager("Amy", 2, "amy123");
            Manager Richa = new Manager("Richa", 3, "richa123");

            store.Managers.Add(Bai);
            store.Managers.Add(Amy);
            store.Managers.Add(Richa);

            //Declare cake list
            Cake ChocolateCake = new Cake("Chocolate Cake",8.5, 1);
            Cake FruitCake = new Cake("Fruit Cake", 10.9, 2);
            Cake SpongeCake = new Cake("Sponge Cake", 12.5, 3, "Roger", "Happy Birth Day!!!!!");
           
            store.Cakes.Add(ChocolateCake);
            store.Cakes.Add(FruitCake);
            store.Cakes.Add(SpongeCake);

            //Declare drink list
            Drink Coca = new Drink("Coca Cola", 3.0, 1, "350");
            Drink Fanta = new Drink("Fanta", 3.0, 2, "350");
            Drink OrangeJuice = new Drink("Orange Juice", 5.5, 3, "500");
            store.Drinks.Add(Coca);
            store.Drinks.Add(Fanta);
            store.Drinks.Add(OrangeJuice);

            
        }
        public static void AppSelectionMenu(Store store)
        {
            var exitSystem = false;

            while (!exitSystem)
            {
                Console.WriteLine("Please select the operation: ");
                Console.WriteLine("1. Manager Registration");
                Console.WriteLine("2. Remove Manager");
                Console.WriteLine("3. Add cake");
                Console.WriteLine("4. Remove cake");
                Console.WriteLine("5. Add writing on cake");
                Console.WriteLine("6. Add drink");
                Console.WriteLine("7. Remove drink");
                Console.WriteLine("8. Search Cake by custmer name");
                Console.WriteLine("9. List items in stock"); 



                Console.WriteLine("99. Exit");

                string selectedAction = Console.ReadLine();
                switch (selectedAction)
                {
                    case "1":
                        store.AddNewManager();
                        break;

                    case "2":
                        store.RemoveManager();
                        break;

                    case "3":
                        store.AddCake();
                        break;

                    case "4":
                        store.RemoveCake();
                        break;

                    case "5":
                        store.addWritingOnCake();
                        break;

                    case "6":
                        store.AddDrink();
                        break;

                    case "7":
                        store.RemoveDrink();
                        break;

                    case "8":
                        store.SearchCakeByCustomerName();
                        break;

                    case "9":

                        store.displayItemList();
                        break;

                    case "99":
                        Console.WriteLine("***You are Exiting the App***");
                        Console.WriteLine("HAVE A GREAT DAY!!!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Wrong choice.. Please try again");
                        Console.WriteLine();
                        break;

                }//end of switch


            }
        }
    }
}
