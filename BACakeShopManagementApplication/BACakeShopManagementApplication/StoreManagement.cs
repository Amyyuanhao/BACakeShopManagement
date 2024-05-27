using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACakeShopManagementApplication
{
    internal class StoreManagement
    {
        public void AddCake (Store store)
        {
            bool keeprunninhg = true;
            while (keeprunninhg)
            {
                Console.WriteLine("***You are Adding a new Cake***");
                Console.WriteLine("-------------------------------");

                Console.WriteLine("Please enter the cake name");
                string cakeName = Console.ReadLine();
                Console.WriteLine("Please enter the cake Price");
                double cakePrice = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the cake ID");
                int cakeId = Convert.ToInt32(Console.ReadLine());

                bool alreadyexist = store.IsCakeIdUsed(cakeId);
                if (alreadyexist)
                {

                    Console.WriteLine("The cake ID has been used.");
                    Console.WriteLine("Please try another Cake ID");
                }

                else
                {
                    store.AddCake(cakeName, cakePrice, cakeId);

                    Console.WriteLine($"The {cakeName} cake has been added\nPrice:\t${cakePrice}\nID:\t{cakeId}");
                    Console.WriteLine();
                    Console.WriteLine($"Now you have {store.Cakes.Count} types of cake\n");
                    Console.WriteLine();
                    foreach (Cake cakeN in store.Cakes)
                    {
                        cakeN.DisplayCakeDetailes();
                        Console.WriteLine();
                    }
                    Console.WriteLine("Please press any key to retuen to Main Menu");
                    Console.ReadKey();
                 
                    keeprunninhg = false;
                }
            }
        }

        public void DeleteCake(Store store)
        {   
            bool keeprunninhg = true;
            while (keeprunninhg)
            {
                Console.WriteLine("***You are removing a cake***");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Please enter cake ID ");
                int idCakeRemove = Convert.ToInt32(Console.ReadLine());

                Cake removeCake = store.Cakes.Find(c => c.Id == idCakeRemove);

                if (removeCake != null)
                {
                    Console.WriteLine($"The Cake Id {idCakeRemove} found in the list");
                    store.Cakes.Remove(removeCake);
                    Console.WriteLine($"Cake Id {idCakeRemove} has been delete successfully");
                    Console.WriteLine();
                    Console.WriteLine($"Now you have {store.Cakes.Count} types of cake");
                    Console.WriteLine();
                    foreach (Cake cakeN in store.Cakes)
                    {
                        cakeN.DisplayCakeDetailes();
                        Console.WriteLine();
                    }
                    Console.WriteLine("Please press any key to retuen to Main Menu");
                    Console.ReadKey();
                    keeprunninhg = false;
                }
                else
                {
                    Console.WriteLine($"The{removeCake} Cake can not found from Cake List!");
                    Console.WriteLine("Please check ID and enter again");
                }   
            }
        }

        public void AddDrink (Store store)
        {
            bool keeprunninhg = true;
            while (keeprunninhg)
            {
                Console.WriteLine("***You are Adding a new Drink***");
                Console.WriteLine("--------------------------------");
                Console.WriteLine();

                Console.WriteLine("Please enter the drink name");
                var drinkName = Console.ReadLine();
                Console.WriteLine("Please enter the drink Price");
                var drinkPrice = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the drink ID");
                var drinkId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the capacity of the drink.");
                var drinkCapacity = Console.ReadLine();
                Console.WriteLine();

                bool alreadyexist = store.IsDrinkIdUsed(drinkId);
                if (alreadyexist)
                {
                    Console.WriteLine("The drink ID has been used.");
                    Console.WriteLine("Please try another Cake ID");
                }
                else
                {
                    store.AddDrink(drinkName, drinkPrice, drinkId, drinkCapacity);
                    Console.WriteLine($"{drinkName} has been added\nPrice:\t${drinkPrice}\nCapacity:\t{drinkCapacity}ml\nID:\t{drinkId}");
                    Console.WriteLine() ;
                    Console.WriteLine($"Now you have {store.Drinks.Count} types of drink\n");
                    Console.WriteLine();
                    foreach (Drink drinkN in store.Drinks)
                    {
                        drinkN.DisplayDrinkDetails();
                        Console.WriteLine();

                    }
                    Console.WriteLine("Please press any key to retuen to Main Menu");
                    Console.ReadKey();

                    keeprunninhg = false;
                }
            }
        }

        public void DeleteDrink(Store store)
        {
            bool keeprunninhg = true;
            while (keeprunninhg)
            {
                Console.WriteLine("***You are removing a drink***");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Please enter drink ID ");
                int idDrinkRemove = Convert.ToInt32(Console.ReadLine());

                Drink removeDrink = store.Drinks.Find(d => d.Id == idDrinkRemove);

                if (removeDrink != null)
                {
                    Console.WriteLine($"The Drink Id {idDrinkRemove} found in the list");
                    store.Drinks.Remove(removeDrink);
                    Console.WriteLine($"Drink Id {idDrinkRemove} has been delete successfully");
                    Console.WriteLine();
                    Console.WriteLine($"Now you have {store.Drinks.Count} types of drink");
                    Console.WriteLine();
                    foreach (Drink drinkY in store.Drinks)
                    {
                        drinkY.DisplayDrinkDetails();
                        Console.WriteLine();
                    }
                    Console.WriteLine("Please press any key to retuen to Main Menu");
                    Console.ReadKey();
                    keeprunninhg = false;
                }
                else
                {
                    Console.WriteLine($"The{removeDrink} Drink can not found from Drink List!");
                    Console.WriteLine("Please check ID and enter again");
                   
                }

                
            }
        }

        public void itemSearch (Store store)
        {
            Console.WriteLine("***Please Enter the custmer name to search order***");
            string custmerName = Console.ReadLine();
            var custmerCakes = store.SearchCakeByCustomerName(custmerName);
            if (custmerCakes.Count != 0)
            {
                Console.WriteLine($"We find cake here");
                foreach (var cake in custmerCakes)
                {
                    cake.DisplayCakeDetailes();

                    Console.WriteLine("Please press any key to retuen to Main Menu");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine($"{custmerCakes} can not found  Please check customer name!");
                Console.WriteLine("Please press any key to retuen to Main Menu");
                Console.ReadKey();
            }
        }
        public void addWritingOnCake (Store store)
        {
            Console.WriteLine("***Please enter Cake ID to add writing message***");
            int idAddWritingCake = Convert.ToInt32(Console.ReadLine());
            Cake addWritingCake = store.Cakes.Find(c => c.Id == idAddWritingCake);

            if (addWritingCake != null)
            {
                Console.WriteLine($"{idAddWritingCake} Cake is ready to write");
                Console.WriteLine("Please enter the custmer name");
                var customerName = Console.ReadLine();
                Console.WriteLine("Please enter the writing message");
                var message = Console.ReadLine();
                Console.WriteLine();
                addWritingCake.WriteMessageOnCake(customerName, message);
                addWritingCake.DisplayCakeDetailes();

                Console.WriteLine("Message is adding successfully!");
                Console.ReadKey ();
                Console.WriteLine("Please press a key to return");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"The ID {idAddWritingCake} of cake can not found!");
                Console.WriteLine("Please press a key to return");
                Console.ReadKey();
            }
        }

        public void displayItemList (Store store)
        {
            Console.WriteLine("*****Cake List*****");
            store.DisplayCakes();
            Console.WriteLine();
            Console.WriteLine("*****Drink List*****");
            store.DisplayDrinks();
            Console.WriteLine();
            Console.WriteLine("Please press a key to return");
            Console.ReadKey();
        }
        public void AddNewManager(List<Manager> managers)
        {

            bool keepRunning = true;

            while (keepRunning)
            {
                string newManagerName, newManagerPassword;
                int newManagerId;

                Console.WriteLine("***You are Adding new manager***");

                Console.WriteLine("Please enter the new Manager Name");
                newManagerName = Console.ReadLine();
                Console.WriteLine("Please enter the new manager password");
                newManagerPassword = Console.ReadLine();
                Console.WriteLine("Please enter the new manager ID");
                newManagerId = Convert.ToInt32(Console.ReadLine());

                bool alreadyExist = false;
                foreach (Manager manager in managers)
                {
                    if (newManagerName == manager.Name)
                    {
                        alreadyExist = true;
                        Console.WriteLine("This manager name has been used, please change one");
                    }
                }

                if (!alreadyExist)
                {
                    Manager manager = new Manager(newManagerName, newManagerId, newManagerPassword);
                    managers.Add(manager);

                    Console.WriteLine($"New manager {newManagerName} has been added successfully, the password is {newManagerPassword}, manager ID is {newManagerId}");

                    Console.WriteLine($"Currently have {managers.Count} managers");

                    keepRunning = false;
                    Console.WriteLine("Please press any key to retuen to Main Menu");
                    Console.WriteLine();
                    Console.ReadKey();
                }

            }

        }

        public void DeleteManager(List<Manager> managers)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                string deleteManagerName;
                Console.WriteLine("***You are Removing a manager***");

                Console.WriteLine("Please enter the Manager Name you want to delete");
                deleteManagerName = Console.ReadLine();

                bool existName = false;
                foreach (Manager manager in managers)
                {
                    if (deleteManagerName == manager.Name)
                    {
                        existName = true;
                    }
                }
                if (existName)
                {
                    Manager removeManager = managers.Find(c => c.Name == deleteManagerName);
                    managers.Remove(removeManager);

                    Console.WriteLine($"Now manager {deleteManagerName} has been delete successfully");

                    Console.WriteLine($"Currently have {managers.Count} managers");

                    Console.WriteLine("Please press any key to retuen to Main Menu");
                    Console.WriteLine();
                    Console.ReadKey();
                    keepRunning = false;
                }
                else
                {
                    Console.WriteLine("Can not find this Manager\nPlease check the Name and enter again");
                }
            }
        }
    }
}
