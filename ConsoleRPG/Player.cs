using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    class Player
    {
        private string playername;
        private string playerclass;
        private string race;
        private int health;
        private int experience = 0;
        private bool darkvision;
        public Player()
        {
            playername = "John Doe";
            playerclass = "Fighter";
            race = "Human";
            health = 100;
            darkvision = false;
        }

        public void ChooseRace(string raceparam)
        {
            switch (raceparam)
            {
                case "1":
                    race = "Human";
                    health = 100;
                    break;
                case "2":
                    race = "Elf";
                    health = 75;
                    darkvision = true;
                    break;
                case "3":
                    race = "Orc";
                    health = 125;
                    break;
                default:
                    Console.WriteLine("Not a valid race.");
                    break;
            }
        }

        public void ChooseClass(string classparam)
        {
            switch (classparam)
            {
                case "1":
                    playerclass = "Fighter";
                    break;
                case "2":
                    playerclass = "Mage";
                    break;
                case "3":
                    playerclass = "Ranger";
                    break;
                default:
                    Console.WriteLine("Not a valid class.");
                    break;
            }
        }

        public void ChooseName(string nameparam)
        {
            playername = nameparam;
        }
        
        public string GetRace()
        {
            return race;
        }

        public string GetClass()
        {
            return playerclass;
        }

        public string GetName()
        {
            return playername;
        }

        public bool HasDarkVision()
        {
            if (darkvision) return true;
            else return false;
        }

        public string ReturnDescription()
        {
            return $"{playername} is a {playerclass} {race}." +
                $"\nXP: {experience}\nHP: {health}";
        }

        

    }
}
