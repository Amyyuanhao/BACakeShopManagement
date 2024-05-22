using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACakeShopManagementApplication
{
    internal class Store
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string  Phonenumber { get; set; }
        public List<Manager>[] managers { get; set; }
        public List<Cake>[] cakes { get; set; }
        public List<Drink>[] drinks { get; set; }

    }
}
