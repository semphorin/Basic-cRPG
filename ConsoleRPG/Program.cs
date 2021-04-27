using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            bool chabool = false;
            string answer;

            Console.WriteLine("Welcome to Basic-cRPG.");

            //rudimentary player initialization

            Player mainCharacter = new Player();

            do
            {
                Console.WriteLine("Character creation started.\n");

                Console.WriteLine("Choosing race.\n1. Human\n2. Elf\n3. Orc");
                mainCharacter.ChooseRace(Console.ReadLine());
                Console.WriteLine($"You chose {mainCharacter.GetRace()}.\n");

                Console.WriteLine("Choosing class.\n1. Fighter\n2. Mage\n3. Ranger");
                mainCharacter.ChooseClass(Console.ReadLine());
                Console.WriteLine($"You chose {mainCharacter.GetClass()}.\n");

                Console.WriteLine("Most importantly... What is your name, adventurer?");
                mainCharacter.ChooseName(Console.ReadLine());
                Console.WriteLine($"So your name is {mainCharacter.GetName()}.");

                Console.WriteLine($"\n\nYour name is: {mainCharacter.GetName()}.\n" +
                    $"Your chosen race is: {mainCharacter.GetRace()}.\n" +
                    $"Your chosen class is: {mainCharacter.GetClass()}.\n" +
                    $"Is this correct? (Y/N)");
                answer = Console.ReadLine().ToLower();
                if (answer == "y") chabool = true;
                else Console.Clear();
            }
            while (chabool == false);

            
            // Main game code below

            
        }
    }
}
