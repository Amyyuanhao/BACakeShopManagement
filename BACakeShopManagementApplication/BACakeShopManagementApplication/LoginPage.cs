using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACakeShopManagementApplication
{
    internal class LoginPage
    {
        public static void IdentityCheck(List<Manager> managers)
        {
            bool loginSuccess = false;
            while (!loginSuccess)
            {
                string inputManagerName, inputManagerPassword;
               

                Console.WriteLine("Please enter the Manager Name");
                inputManagerName = Console.ReadLine();
                Console.WriteLine("Please enter the manager password");
                inputManagerPassword = Console.ReadLine();
                foreach (Manager manager in managers)
                {
                    if (manager.Name == inputManagerName && manager.PassWord == inputManagerPassword)
                    {
                        loginSuccess = true;
                    }
                }

                if (!loginSuccess)
                    Console.WriteLine("Sorry, You are unauthorized \nPlease check your name and password \nPlease Try Again!");

            }
        }
    }
}
