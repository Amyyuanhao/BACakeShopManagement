using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACakeShopManagementApplication
{
    internal interface IManagement
    {
        void AddCake();
        void RemoveCake();

        void AddDrink();
        void RemoveDrink();

        void AddNewManager();
        void RemoveManager();

    }
}
 