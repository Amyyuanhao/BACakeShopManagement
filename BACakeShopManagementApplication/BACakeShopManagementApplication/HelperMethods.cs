using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACakeShopManagementApplication
{
    public static class HelperMethods
    {
        public static double InputPrice()
        {
            var maxRetry = 3;
            var retry = 0;
            var exitInput = false;
            double price = 0;

            while (!exitInput)
            {
                Console.WriteLine("Please enter the cake Price");
                var stringPrice = Console.ReadLine();
                try
                {
                    price = Convert.ToDouble(stringPrice);
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid price, please try enter again");
                    retry++;
                    if (retry == maxRetry)
                    {
                        Console.WriteLine("You have tried three times, price will be set to 0, please update it later.");
                        exitInput = true;
                    }
                }
            }

            return price;
        }
    }
}
