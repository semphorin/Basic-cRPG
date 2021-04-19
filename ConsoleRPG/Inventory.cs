using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    class Inventory
    {
        private string[] weapons;
        private string[] consumables;
        private string[] armor;
        public Inventory()
        {
            Console.WriteLine("Your inventory is empty.");
        }
    }
}
