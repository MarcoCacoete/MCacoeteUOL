using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Player                       // Extra class that creates a player object with 3 arguments

    {

        private string name;       // Declaring private variables for player class 

        private int age;

        private string nationality;

        public string playerName  // Private variable gets and sets
        {
            get { return name; }
            set { name = value; }
        }

        public int playerAge
        {
            get { return age; }
            set { age = value; }
        }

        public string playerNationality
        {
            get { return nationality; }
            set { nationality = value; }
        }
        public Player(string playerName, string playerNationality, int playerAge)  // Constructor for player object
        {
            name = playerName;
            age = playerAge;
            nationality = playerNationality;
            return;
        }
        public static Player welcome()   // Welcome function is started from testing class, executes private player welcome function.
        {
            return playerWelcome();
        }
        private string greeting()   // Small greeting function for fun
        {
            Console.WriteLine();

            string greeting = "A round of applause for " + playerName + " our " + playerAge + " year old " + playerNationality + " friend. ";

            Console.WriteLine();

            return greeting;
        }
        private static Player playerWelcome()          // Small private method that is responsible for welcoming the player, and creating a player object with some arguments
        {
            Console.WriteLine("Welcome to the testing class.");

            Console.WriteLine("What is your name?");   // Small section asking user for simple inputs

            string playerName = Console.ReadLine();

            int playerAge;

            enterAge();              // Small function to do error handling in case input doesn't match expected data type using try catch method.

            int enterAge()
            {
                try
                {

                    Console.WriteLine("How old are you?");
                    playerAge = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    Console.WriteLine("Please enter a correct numerical value.");
                    enterAge();

                }
                return playerAge;
            }

            Console.WriteLine("What is your nationality?");

            string playerNationality = Console.ReadLine();



            Player player = new Player(playerName, playerNationality, playerAge);

            Console.WriteLine(player.greeting());      // Calls greeting method in player class

            return player;                             // Returns player object
        }
    }
}
