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
            pack.ShuffleCardPack(0);
            pack.PrintPack();
            Console.ReadLine();

            
        }
    }
}
