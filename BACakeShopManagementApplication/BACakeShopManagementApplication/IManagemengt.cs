using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACakeShopManagementApplication
{
    internal interface IManagemengt
    {
        void AddCake(string cakeName, double cakePrice, int cakeId);
        void RemoveCake(int cakeId);
    }
}
