using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Program
    {
       static void Main(string[] args)
        {
            Pack.shuffleCardPack(3);
            Console.WriteLine("Welcome to the testing class.");

            test();

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
                    optionsChoice = Convert.ToInt32(options);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please pick valid option.");
                    test();
                }
                

                if (optionsChoice == 1)
                {

                    shuffle();
                    deal();
                    return;
                }

                if (optionsChoice == 2)
                {
                    deal();
                    return;
                }
                else
                {
                    Console.WriteLine("Pick a valid option please.");
                    test();
                    return;
                }
            }

            void deal()
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to deal 1 card or many cards? ");
                Console.WriteLine("1: One. ");
                Console.WriteLine("2: Many cards. ");

                int typeOfDeal=0;

                string option = Console.ReadLine();

                try
                {
                    typeOfDeal = Convert.ToInt32(option);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please pick valid option.");
                    deal();
                }
                if (typeOfDeal == 1)
                {
                    Console.WriteLine("Your dealt cards so far.");

                    Pack.deal();
                }
                if (typeOfDeal == 2)
                {
                    Console.WriteLine("How many cards should be dealt? ");
                    int numberDealt = Convert.ToInt32(Console.ReadLine());

                    Pack.dealCard(numberDealt);
                    deal();
                }
                else
                {
                    deal();
                }
                deal();
            }

            void shuffle()
            {
                Console.WriteLine("Which type of shuffle would you prefer? ");
                Console.WriteLine("1: Yates. ");
                Console.WriteLine("2: Riffle shuffle. ");
                Console.WriteLine("3: No shuffle. ");

                int typeOfShuffle = 0;

                string options = Console.ReadLine();
                
                try
                {
                  typeOfShuffle = Convert.ToInt32(options);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please pick valid option.");
                    shuffle();
                }
                if (typeOfShuffle == 1)
                {
                    Pack.shuffleCardPack(typeOfShuffle);
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
                    Console.WriteLine("Enter correct option.");
                    shuffle();
                }
                deal();
            }

            Console.ReadLine();
       }
    }
}
       