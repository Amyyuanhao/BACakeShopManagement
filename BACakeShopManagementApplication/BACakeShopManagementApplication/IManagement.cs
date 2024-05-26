using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACakeShopManagementApplication
{
    internal interface IManagement
    {
        void AddCake(string cakeName, double cakePrice, int cakeId);
        void RemoveCake(int cakeId);

        void AddDrink(string drinkName, double drinkPrice, int drinkId, string drinapacity);
        void RemoveDrink(int drinkId);
    }
}
 