using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public List<Card> pack = new List<Card>();

        public void Create()
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
            Console.WriteLine("There are " + deck.Length + " cards on the table. Putting them into a pack...");
            foreach (Card card in deck)
            {
                pack.Add(card);
            }
            Console.WriteLine("There are " + pack.Count + " cards in the pack.");
        }

        public static bool ShuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle

            return false;
        }
        public Card Deal()
        {
            Console.WriteLine("Card Dealt: " + this.pack.ElementAt(0));
            this.pack.Remove(this.pack.ElementAt(0));
            Console.WriteLine("Only " + this.pack.Count + " cards remain.");
            return null;
        }
        public List<Card> DealCard(int amount)
        {
            List<Card> cards = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                cards.Add(pack.ElementAt(i));
                this.pack.Remove(this.pack.ElementAt(i));
            }
            foreach (Card card in cards)
            {
                Console.WriteLine(card.ToString());
            }
            Console.WriteLine("Only " + this.pack.Count + " cards remain.");
            return cards;
        }
        public void PrintPack()
        {
            foreach(Card card in this.pack)
            {
                Console.WriteLine(card.ToString());
            }
            Console.WriteLine("There are " + this.pack.Count + " cards in the pack.");
        }
    }
}
