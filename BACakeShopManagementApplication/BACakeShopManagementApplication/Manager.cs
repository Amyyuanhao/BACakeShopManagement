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
            _id = id;
            PassWord = passWord;
        }

        private readonly int _id;

        
        public string PassWord { get; set; }
        

        public string Name { get; set; } 
        public int Id 
        { 
            get { return _id; } 
        }
       
        
    }
}
