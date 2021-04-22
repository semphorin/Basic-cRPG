using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleRPG
{
    public class Enemy
    {
        // Each of these are properties of the Enemy
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int Damage { get; set; }
    }
}