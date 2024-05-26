using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACakeShopManagementApplication
{
    internal class ManagerManagement
    {
        public void AddNewManager(List<Manager> managers)
        {
           
            bool keepRunning = true;

            while(keepRunning)
            {
                string newManagerName, newManagerPassword;
                int newManagerId;

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
                }   
               
            }
           
        }

        public void DeleteManager (List<Manager> managers)
        {
            bool keepRunning = true;

            while(keepRunning)
            {
                string deleteManagerName;
              
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

                    Console.WriteLine($"New manager {deleteManagerName} has been delete successfully");

                    Console.WriteLine($"Currently have {managers.Count} managers");

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
