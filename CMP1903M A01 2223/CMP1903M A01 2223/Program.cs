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
            Card[] deck = new Card[52];
            int j = 1;
            for (int i = 0; i < 13; i++)
            {
                deck[i] = new Card(j, 0);
                j++;
            }
            j = 1;
            for (int i = 13; i < 26; i++)
            {
                deck[i] = new Card(j, 1);
                j++;
            }
            j = 1;
            for (int i = 26; i < 39; i++)
            {
                deck[i] = new Card(j, 2);
                j++;
            }
            j = 1;
            for (int i = 39; i < 52; i++)
            {
                deck[i] = new Card(j, 3);
                j++;
            }
            j = 0;
            foreach (Card card in deck)
            {
                Console.WriteLine(card.ToString());
            }
            Console.ReadLine();

            Pack pack = new Pack();
            
        }
    }
}
