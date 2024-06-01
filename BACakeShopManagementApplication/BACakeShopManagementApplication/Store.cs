using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BACakeShopManagementApplication
{
    internal class Store: IManagement
    {
        private readonly string _name;

        public Store(string name, string address, string phonenumber)
        {
            _name = name;
            Address = address;
            Phonenumber = phonenumber;
        }

        public string Name 
        {
            get
            {
                return _name;
            }
        }
        public string Address { get; set; }
        public string Phonenumber { get; set; }
        public List<Manager> Managers { get; set; } = new List<Manager> ();
        public List<Cake> Cakes { get; set; } = new List<Cake>();
        public List<Drink> Drinks { get; set; } = new List<Drink>();

        public void AddCake()
        {
            bool keeprunninhg = true;
            while (keeprunninhg)
            {
                Console.WriteLine("***You are Adding a new Cake***");
                Console.WriteLine("-------------------------------");

                Console.WriteLine("Please enter the cake name");
                string cakeName = Console.ReadLine();                
                double cakePrice = HelperMethods.InputPrice();
                Console.WriteLine("Please enter the cake ID");
                int cakeId = Convert.ToInt32(Console.ReadLine());

                bool alreadyexist = IsCakeIdUsed(cakeId);
                if (alreadyexist)
                {

                    Console.WriteLine("The cake ID has been used.");
                    Console.WriteLine("Please try another Cake ID");
                }

                else
                {
                    Cake newCake = new Cake(cakeName, cakePrice, cakeId);
                    Cakes.Add(newCake);

                    Console.WriteLine($"The {cakeName} cake has been added\nPrice:\t${cakePrice}\nID:\t{cakeId}");
                    Console.WriteLine();
                    Console.WriteLine($"Now you have {Cakes.Count} types of cake\n");
                    Console.WriteLine();
                    foreach (Cake cakeN in Cakes)
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

        public void DisplayCakeStoreDitails(string name, string address, string phoneNumber) 
        {
            Console.WriteLine($"Company name: \t{name}\nAddress: \t{address}\nPhone number: \t{phoneNumber}\n");
        }
        public void DisplayCakes()            
        {
            if (this.Cakes.Count == 0)
            {
                Console.WriteLine("No cake in the store\n Please add your first Cake\n");
            }
            else
            {
                foreach (Cake cakeA in this.Cakes)
                {
                    cakeA.DisplayCakeDetailes();
                }
            }
        }

        public void RemoveCake()
        {
            bool keeprunninhg = true;
            while (keeprunninhg)
            {
                Console.WriteLine("***You are removing a cake***");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Please enter cake ID ");
                int idCakeRemove = Convert.ToInt32(Console.ReadLine());

                Cake removeCake = Cakes.Find(cake => cake.Id == idCakeRemove);

                if (removeCake != null)
                {
                    Console.WriteLine($"The Cake Id {idCakeRemove} found in the list");
                   Cakes.Remove(removeCake);
                    Console.WriteLine($"Cake Id {idCakeRemove} has been delete successfully");
                    Console.WriteLine();
                    Console.WriteLine($"Now you have {Cakes.Count} types of cake");
                    Console.WriteLine();
                    foreach (Cake cakeN in Cakes)
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

        public void AddDrink()
        {
            bool keeprunninhg = true;
            while (keeprunninhg)
            {
                Console.WriteLine("***You are Adding a new Drink***");
                Console.WriteLine("--------------------------------");
                Console.WriteLine();
  
                Console.WriteLine("Please enter the drink name");
                var drinkName = Console.ReadLine();
                var drinkPrice = HelperMethods.InputPrice();
                Console.WriteLine("Please enter the drink ID");
                var drinkId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the capacity of the drink.");
                var drinkCapacity = Console.ReadLine();
                Console.WriteLine();

                bool alreadyexist = IsDrinkIdUsed(drinkId);
                if (alreadyexist)
                {
                    Console.WriteLine("The drink ID has been used.");
                    Console.WriteLine("Please try another Drink ID");
                }
                else
                {
                    Drink newDrink = new Drink(drinkName, drinkPrice, drinkId, drinkCapacity);
                    Drinks.Add(newDrink);
                    Console.WriteLine($"{drinkName} has been added\nPrice:\t${drinkPrice}\nCapacity:\t{drinkCapacity}ml\nID:\t{drinkId}");
                    Console.WriteLine();
                    Console.WriteLine($"Now you have {Drinks.Count} types of drink\n");
                    Console.WriteLine();
                    foreach (Drink drinkN in Drinks)
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

        public void RemoveDrink()
        {
            bool keeprunninhg = true;
            while (keeprunninhg)
            {
                Console.WriteLine("***You are removing a drink***");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Please enter drink ID ");
                int idDrinkRemove = Convert.ToInt32(Console.ReadLine());

                Drink removeDrink = Drinks.Find(d => d.Id == idDrinkRemove);

                if (removeDrink != null)
                {
                    Console.WriteLine($"The Drink Id {idDrinkRemove} found in the list");
                    Drinks.Remove(removeDrink);
                    Console.WriteLine($"Drink Id {idDrinkRemove} has been delete successfully");
                    Console.WriteLine();
                    Console.WriteLine($"Now you have {Drinks.Count} types of drink");
                    Console.WriteLine();
                    foreach (Drink drinkY in Drinks)
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

        public void DisplayDrinks()
        {
            if (this.Drinks.Count == 0)
            {
                Console.WriteLine("No drink in the store\n Please add your first Drink\n");
            }
            else
            {
                foreach (Drink drinkA in this.Drinks)
                {
                    drinkA.DisplayDrinkDetails();
                }
            }
        }
        public bool IsCakeIdUsed(int cakeId)
        {
            var cake = Cakes.Find(c => c.Id == cakeId);
            if (cake != null)
            {
                return true;
            }
            return false;
        }

        public void SearchCakeByCustomerName()
        {
            Console.WriteLine("***Please Enter the custmer name to search order***");
            string customerName = Console.ReadLine();
            var custmerCakes = Cakes.FindAll(c => c.CustmorName == customerName);
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

        public bool IsDrinkIdUsed(int drinkId)
        {
            var drink = Drinks.Find(c => c.Id == drinkId);
            if (drink != null)
            {
                return true;
            }
            return false;
        }

        public void addWritingOnCake()
        {
            Console.WriteLine("***Please enter Cake ID to add writing message***");
            int idAddWritingCake = Convert.ToInt32(Console.ReadLine());
            Cake addWritingCake = Cakes.Find(c => c.Id == idAddWritingCake);

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
                Console.ReadKey();
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

        public void displayItemList()
        {
            Console.WriteLine("*****Cake List*****");
            DisplayCakes();
            Console.WriteLine();
            Console.WriteLine("*****Drink List*****");
            DisplayDrinks();
            Console.WriteLine();
            Console.WriteLine("Please press a key to return");
            Console.ReadKey();
        }

        public void AddNewManager()
        {

            bool keepRunning = true;

            while (keepRunning)
            {
                string newManagerName, newManagerPassword;
                int newManagerId;

                Console.WriteLine("***You are signing up a new manager***");

                Console.WriteLine("Please enter the new Manager Name");
                newManagerName = Console.ReadLine();
                Console.WriteLine("Please enter the new manager password");
                newManagerPassword = Console.ReadLine();
                Console.WriteLine("Please enter the new manager ID");
                newManagerId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                bool alreadyExist = false;
                foreach (Manager manager in Managers)
                {
                    if (newManagerName == manager.Name)
                    {
                        alreadyExist = true;
                        Console.WriteLine("This manager information has been used. Please use another one");
                    }
                }

                if (!alreadyExist)
                {
                    Manager manager = new Manager(newManagerName, newManagerId, newManagerPassword);
                    Managers.Add(manager);

                    Console.WriteLine($"New manager {newManagerName} registration has been successfully \nPassword: \t {newManagerPassword}\nManager ID: \t{newManagerId}");

                    Console.WriteLine($"Currently have {Managers.Count} managers");
                    Console.WriteLine();

                    keepRunning = false;
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to retuen to Main Menu");
                    Console.ReadKey();
                }

            }

        }

        public void RemoveManager()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                int deleteManagerID;
                Console.WriteLine("***You are Removing a manager***");

                Console.WriteLine("Please enter the Manager ID you want to delete");
                deleteManagerID = Convert.ToInt32(Console.ReadLine());

                bool existID = false;
                foreach (Manager manager in Managers)
                {
                    if (deleteManagerID == manager.Id)
                    {
                        existID = true;
                    }
                }
                if (existID)
                {
                    Manager removeManager = Managers.Find(c => c.Id == deleteManagerID);
                    Managers.Remove(removeManager);

                    Console.WriteLine($"Manager ID: {deleteManagerID} has been remove successfully");
                    Console.WriteLine();
                    Console.WriteLine($"Currently have {Managers.Count} managers");
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to retuen to Main Menu");
                    Console.ReadKey();
                    keepRunning = false;
                }
                else
                {
                    Console.WriteLine("Can not find this Manager ID\nPlease check the ID and enter again");
                    Console.WriteLine();
                }
            }
        }        
    }
}
 