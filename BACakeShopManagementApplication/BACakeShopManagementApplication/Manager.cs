using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACakeShopManagementApplication
{
    internal class Manager
    {
        public Manager(string name, int id, string passWord)
        {
            Name = name;
            Id = id;
            PassWord = passWord;
        }

        public string PassWord { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }    
}
