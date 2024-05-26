using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACakeShopManagementApplication
{
    internal class Drink:Item
    {
        public string Capacity { get; set; }

        

        public Drink(string drinkName, double drinkPrice, int id, string drindCapacity)
        {
            Name = drinkName;
            Price = drinkPrice;
            Id = id;
            Capacity = drindCapacity;
        }

        public void DisplayDrinkDetails()
        {
            Console.WriteLine($"Drink Name:    \t{Name}\nDrink Price:  \t{Price}\nDrink capacity:\t{Capacity}\nDrink ID:  \t{Id}\n");
        }
            

            
        

    }
}
