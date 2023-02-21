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

                Pack.shuffleCardPack(typeOfShuffle);




            }
        }
    }
}