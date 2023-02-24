using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Program
    {
        static void Main(string[] args)
        {

            Pack pack = new Pack();

            Console.WriteLine("Would you like to shuffle? y/n ");

            string choiceToShuffle = Console.ReadLine();

            if (choiceToShuffle == "y")
            {
                Console.WriteLine("Which type of shuffle would you prefer? ");
                Console.WriteLine("1: Yates. ");
                Console.WriteLine("2: Riffle shuffle. ");
                Console.WriteLine("3: No shuffle. ");
                int typeOfShuffle = Convert.ToInt32(Console.ReadLine());

                //pack.shuffleCardPack(typeOfShuffle);

                pack.shuffleCardPack(typeOfShuffle);

                Console.WriteLine("Would you like to deal? y/n ");

                string dealChoice = Console.ReadLine();

                if (dealChoice == "y")
                {

                    Console.WriteLine("Would hou like to deal 1 card or many cards? ");
                    Console.WriteLine("1: One. ");
                    Console.WriteLine("2: Many cards. ");
                    int typeOfDeal = Convert.ToInt32(Console.ReadLine());
                    if(typeOfDeal == 1)
                    {
                        pack.deal();
                    }
                    else
                    {
                        Console.WriteLine("How many cards should be dealt? ");
                        int numberDealt = Convert.ToInt32(Console.ReadLine());
                        pack.dealCard(numberDealt);
                    }
                }

                


                Console.ReadLine();

            }
        }
    }
}