using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACakeShopManagementApplication
{
    internal class Store: IManagemengt
    {
        private readonly string _name;

        public Store(string name, string address, string phonenumber, string managerName, string managerPassword)
        {
            _name = name;
            Address = address;
            Phonenumber = phonenumber;
            Managers.Add(new Manager(managerName, 1, managerPassword));
        }

        public string Name 
        {
            get
            {
                return _name;
            }
        }
        public string Address { get; set; }
        public string Phonenumber { get; set; }
        public List<Manager> Managers { get; set; } = new List<Manager> ();
        public List<Cake> Cakes { get; set; } = new List<Cake>();
        public List<Drink> Drinks { get; set; } = new List<Drink>();

        public void DisplayCakeStoreDitails(string name, string address, string phoneNumber) 
        {
            Console.WriteLine($"Company name: \t{name}\nAddress: \t{address}\nPhone number: \t{phoneNumber}\n");
        }

        public void AddCake(string cakeName, double cakePrice, int cakeId)
        {
            Cakes.Add(new Cake(cakeName, cakePrice, cakeId));
        }

        void IManagemengt.RemoveCake(int cakeId)
        {
            throw new NotImplementedException();
        }
    }
}
