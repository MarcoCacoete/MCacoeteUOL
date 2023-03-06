using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Testing
    {
        private static string playerName;
        private static string playerAge;
        private static int playerNationality;

        static void Main(string[] args)
        {
            Pack pack = new Pack();  //  Creates a pack of ordered cards
                                     


            welcome();                // Calls small function to welcome user to testing class,

            void welcome()                                       // this is an example of abstraction because it reduces a more complex process to a simple method call
            {                                                    // the end user is also only able to interact with the program through the interface that I set up without
                                                                 // needing to know about inner workings
                Player testPlayer = Player.welcome();
            }


            test();                   // Call to test method which "kickstarts" the methods to be tested including deal() and shuffleCardPack()
                                      // another example of abstraction 
            void test()
            {
                Console.WriteLine();
                Console.WriteLine("Here are some options.");
                Console.WriteLine();
                Console.WriteLine("To shuffle enter 1: ");
                Console.WriteLine("To deal enter 2: ");

                int optionsChoice = 0;

                string options = Console.ReadLine();
                try
                {
                    optionsChoice = Convert.ToInt32(options);   // More error handling is done in this small block
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    Console.WriteLine("Please pick valid option.");
                    Console.WriteLine();
                    test();
                }

                if (optionsChoice == 1)
                {

                    shuffleCardPack();
                    deal();
                    return;
                }                                               // A few if statements to determine which type of task to be executed deal or shuffle 
                                                                // when shuffle is called, deal is automatically called after, to test dealing shuffled packs
                if (optionsChoice == 2)
                {
                    deal();
                    return;
                }
                else
                {
                    Console.WriteLine("Pick a valid option please.");  // More error handling in the form of an else statement with recursive function call in test()
                    test();
                    return;
                }
            }

            void deal()                                                 // Deal method not called directly but through test function, possible example of encapsulation
                                                                        // and abstraction
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to deal 1 card or many cards? ");
                Console.WriteLine("1: One. ");
                Console.WriteLine("2: Many cards. ");

                int typeOfdeal = 0;

                string option = Console.ReadLine();

                try
                {
                    typeOfdeal = Convert.ToInt32(option);
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    Console.WriteLine("Please pick valid option.");  // Similar method to above method to this time determine type of deal, calls encapsulated dealer method.
                    deal();
                }
                if (typeOfdeal == 1)
                {
                    Console.WriteLine("Your dealt cards so far.");

                    Pack.dealer(1, 0);
                    deal();
                }
                if (typeOfdeal == 2)
                {
                    Console.WriteLine("How many cards should be dealt? ");
                    int numberdealt = Convert.ToInt32(Console.ReadLine());

                    Pack.dealer(2, numberdealt);
                    deal();
                }
                else
                {
                    deal();
                }
            }

            void shuffleCardPack()
            {
                Console.WriteLine("Which type of shuffle would you prefer? ");
                Console.WriteLine("1: Fisher-Yates. ");
                Console.WriteLine("2: Riffle shuffle. ");
                Console.WriteLine("3: No shuffle. ");

                int typeOfShuffle = 0;

                string options = Console.ReadLine();

                try
                {
                    typeOfShuffle = Convert.ToInt32(options);       // Same type of error handling as above
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    Console.WriteLine("Please pick valid option.");
                    shuffleCardPack();
                }
                if (typeOfShuffle == 1)
                {
                    Pack.shuffleCardPack(typeOfShuffle);          // Again same method as above, this time to determine type of shuffle to be executed
                    return;
                }
                if (typeOfShuffle == 2)
                {
                    Pack.shuffleCardPack(typeOfShuffle);
                    return;
                }
                if (typeOfShuffle == 3)
                {
                    Pack.shuffleCardPack(typeOfShuffle);
                    return;
                }
                else
                {
                    Console.WriteLine("Enter correct option."); // Error handling for incorrect user input
                    shuffleCardPack();
                }
                deal();
            }

            Console.ReadLine();
        }
    }
}
