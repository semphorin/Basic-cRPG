using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    class Weapon
    {
        public int damage = 1;
        public int durability = 100;
        public int range;
        public string weaponname;

        public int Crit()
        {
            return damage *= 2;
        }
    }

    class Sword : Weapon
    {
        public Sword()
        {
            damage = 20;
            weaponname = "Simple Sword";
            range = 5;
        }
    }
    class Bow : Weapon
    {
        public Bow()
        {
            damage = 10;
            weaponname = "Simple Bow";
            range = 25;
        }
    }
}
