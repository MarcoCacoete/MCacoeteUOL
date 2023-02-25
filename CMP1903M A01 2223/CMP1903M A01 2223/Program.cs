using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuMain();
        }
        static void MenuMain()
        {
            string choice;
            Console.WriteLine("╔═════════════════════════════════════════════╗");
            Console.WriteLine("║ Select an Option:                           ║");
            Console.WriteLine("╠═════════════════════════════════════════════╣");
            Console.WriteLine("║ 1. User-Input Based Operation               ║");
            Console.WriteLine("║ 2. Structured Testing Options               ║");
            Console.WriteLine("╚═════════════════════════════════════════════╝");
            Console.Write("> ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    UserMenu();
                    break;
                case "2":
                    Console.Clear();
                    TestingMenu();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("> Select a valid option");
                    Console.ForegroundColor = ConsoleColor.White;
                    MenuMain();
                    break;
            }

        }
        static void UserMenu()
        {
            Pack pack = new Pack();
            string choice;
            Console.WriteLine("╔═════════════════════════════════════════════╗");
            Console.WriteLine("║ User-Input                                  ║");
            Console.WriteLine("╠═════════════════════════════════════════════╣");
            Console.WriteLine("║ Would you like to create a pack?  (Y/N)     ║");
            Console.WriteLine("╚═════════════════════════════════════════════╝");
            Console.Write("> ");
            choice = Console.ReadLine();
            if (choice == "Y" || choice == "y")
            {
                
                pack.Create();
                Console.Clear();

            }
            else if (choice == "N" || choice == "n")
            {
                Console.Clear();
                MenuMain();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("> Select a valid option.");
                Console.ForegroundColor = ConsoleColor.White;
                UserMenu();
            }
            Console.WriteLine("╔═════════════════════════════════════════════╗");
            Console.WriteLine("║ What would you like to do?                  ║");
            Console.WriteLine("╠═════════════════════════════════════════════╣");
            Console.WriteLine("║ 1. View the pack?                           ║");
            Console.WriteLine("║ 2. Deal a card?                             ║");
            Console.WriteLine("║ 3. Deal a number of cards?                  ║");
            Console.WriteLine("║ 4. Shuffle the pack?                        ║");
            Console.WriteLine("║ 5. Quit & Return to main menu               ║");
            Console.WriteLine("╚═════════════════════════════════════════════╝");
            Console.Write("> ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    pack.PrintPack();
                    break;
                case "2":
                    // Code to deal a card
                    break;
                case "3":
                    // Code to deal a number of cards
                    break;
                case "4":
                    // Code to shuffle the pack
                    break;
                case "5":
                    // Code to quit and return to main menu
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
        static void TestingMenu()
        {

        }
    }
}
