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
            Pack pack = new Pack();
            pack.Create();
            Console.ReadLine();
            pack.ShuffleCardPack(0);
            Console.ReadLine();
            pack.PrintPack();
            Console.ReadLine();
            pack.Deal();
            pack.DealCard(10);
            Console.ReadLine();
            pack.PrintPack();
            Console.ReadLine();
            pack.ShuffleCardPack(34);
            Console.ReadLine();
            pack.DealCard(41);
            Console.ReadLine();
            pack.Deal();
            Console.ReadLine();

        }
    }
}
