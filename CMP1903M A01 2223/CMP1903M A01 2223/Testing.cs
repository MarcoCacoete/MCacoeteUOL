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

            //Pack pack = new Pack();

            test(); 

            void test ()
            {
            Console.WriteLine("Welcome to the testing class.");
            Console.WriteLine();
            Console.WriteLine("Here are some options.");
            Console.WriteLine();
            Console.WriteLine("To shuffle enter 1: ");
            Console.WriteLine("To deal enter 2: ");

            string options = Console.ReadLine();

            int optionsChoice = Convert.ToInt32(options);

            if (optionsChoice == 1)
            {


                Console.WriteLine("Which type of shuffle would you prefer? ");
                Console.WriteLine("1: Yates. ");
                Console.WriteLine("2: Riffle shuffle. ");
                Console.WriteLine("3: No shuffle. ");

                int typeOfShuffle = Convert.ToInt32(Console.ReadLine());

                Pack.shuffleCardPack(typeOfShuffle);

            }

            if (optionsChoice == 2)
            {

                Console.WriteLine("Would hou like to deal 1 card or many cards? ");
                Console.WriteLine("1: One. ");
                Console.WriteLine("2: Many cards. ");
                int typeOfDeal = Convert.ToInt32(Console.ReadLine());
                if (typeOfDeal == 1)
                {
                    Pack.deal();
                }
                if (typeOfDeal == 2)
                {
                    Console.WriteLine("How many cards should be dealt? ");
                    int numberDealt = Convert.ToInt32(Console.ReadLine());
                    Pack.dealCard(numberDealt);
                }
                else
                {
                    test();
                }

            }
            else
            { 
                test();
            }
            }
        }
    }
}