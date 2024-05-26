using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACakeShopManagementApplication
{
    internal class Store: IManagement
    {
        private readonly string _name;

        public Store(string name, string address, string phonenumber, string managerName, string managerPassword)
        {
            _name = name;
            Address = address;
            Phonenumber = phonenumber;
            Managers.Add(new Manager(managerName, 1, managerPassword));
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

        public void AddCake(string cakeName, double cakePrice, int cakeId)
        {
            Cake newCake = new Cake(cakeName, cakePrice, cakeId);
            Cakes.Add(newCake);
        }

        public void DisplayCakeStoreDitails(string name, string address, string phoneNumber) 
        {
            Console.WriteLine($"Company name: \t{name}\nAddress: \t{address}\nPhone number: \t{phoneNumber}\n");
        }
        public void DisplayCakes()            
        {
            if (this.Cakes.Count == 0)
            {
                Console.WriteLine("No cake in the store");
            }
            else
            {
                foreach (Cake cakeA in this.Cakes)
                {
                    cakeA.DisplayCakeDetailes();
                }
            }
        }

        public void RemoveCake(int cakeId)
        {
            Cake removeCake= Cakes[cakeId];
            Cakes.Remove(removeCake);
        }

        public void AddDrink(string drinkName, double drinkPrice, int drinkId, string drinkCapacity)
        {
            Drink newDrink = new Drink(drinkName, drinkPrice, drinkId, drinkCapacity);
            Drinks.Add(newDrink);
        }

        public void RemoveDrink(int drinkId)
        {
            Drink removeDrink= Drinks[drinkId];
            Drinks.Remove(removeDrink);
        }

        public void DisplayDrinks()
        {
            if (this.Drinks.Count == 0)
            {
                Console.WriteLine("No drink in the store");
            }
            else
            {
                foreach (Drink drinkA in this.Drinks)
                {
                    drinkA.DisplayDrinkDetails();
                }
            }
        }
    }
}
 