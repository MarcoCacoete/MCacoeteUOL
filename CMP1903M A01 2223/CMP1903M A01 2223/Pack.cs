using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public List<Card> pack = new List<Card>();
        public bool packExists = false;
        public void Create()
        {
            
            if (packExists == false)
            {
                Card[] deck = new Card[52];
                int k = 0;
                for (int j = 0; j < 4; j++)
                {
                    for (int i = 1; i < 14; i++)
                    {
                        deck[k] = new Card(i, j);
                        k++;
                    }
                }
                Console.WriteLine("There are " + deck.Length + " cards on the table. Putting them into a pack...");
                foreach (Card card in deck)
                {
                    Console.WriteLine("Adding " + card + ".");
                    pack.Add(card);
                }

                Console.WriteLine("There are " + pack.Count + " cards in the pack.");
                packExists = true;
            }
            else if (packExists == true)
            {
                Console.WriteLine("A pack already exists.");
            }
            
        }

        public bool ShuffleCardPack(int typeOfShuffle)
        {
            Random randNo = new Random();
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 0)
            {
                // Fisher-Yates
                Console.WriteLine("Attempting a Fisher-Yates Shuffle...");
                
                for (int i = this.pack.Count - 1; i > 0; i--)
                {
                    int j = randNo.Next(i + 1);
                    this.pack.Swap(i, j);
                    
                }
                Console.WriteLine("Shuffled the deck.");
                return true;
            }
            if (typeOfShuffle == 1)
            {
                // Riffle Shuffle
                Console.WriteLine("Attempting a Riffle Shuffle...");
                // Split Deck into two, create two lists to store the split deck.
                int half = this.pack.Count / 2;
                Console.WriteLine("Splitting the pack in two. And making two piles of cards on the table.");
                List<Card> left = new List<Card>();
                List<Card> right = new List<Card>();

                // Get cards between index 0, and half-way
                left = this.pack.GetRange(0, half);
                Console.WriteLine("There are " + left.Count + " card(s) in the stack on the left.");
                // Get the remaining cards by taking the value of half, and removing that count from the selection
                right = this.pack.GetRange(half, this.pack.Count - half);
                Console.WriteLine("There are " + right.Count + " card(s) in the stack on the right.");

                // Empty our pack, as all the cards on the table. 
                this.pack.Clear();
                Console.WriteLine("The pack contains " + this.pack.Count + " card(s). There are now two piles containing " + (left.Count + right.Count) + " card(s).");

                // While we still have cards in either half...
                while (left.Count > 0 && right.Count > 0)
                {
                    Console.WriteLine("Riffling the two piles...");
                    // The riffle shuffle isn't a perfect overlap of each card. Lets take up to 5 cards, at random to "overlap"
                    int cardOverlap = randNo.Next(1, 5);

                    // We don't want to take more cards than we actually have, so make sure it isn't any higher than the pile.
                    cardOverlap = Math.Min(cardOverlap, left.Count);
                    Console.WriteLine(cardOverlap + " card(s) overlapped on the left.");
                    // Make a list that has all the cards that overlapped, starting from 0, up to our Rgen Number.
                    List<Card> cardsOverlapped = left.GetRange(0, cardOverlap);

                    // Take those cards out of the left pile.
                    left.RemoveRange(0, cardOverlap);

                    // Take all the cards we removed, and put them into our pile again.
                    this.pack.AddRange(cardsOverlapped);

                    // Repeat code but for the right...
                    cardOverlap = randNo.Next(1, 5);
                    cardOverlap = Math.Min(cardOverlap, right.Count);
                    Console.WriteLine(cardOverlap + " card(s) overlapped on the right");
                    cardsOverlapped = right.GetRange(0, cardOverlap);
                    right.RemoveRange(0, cardOverlap);
                    this.pack.AddRange(cardsOverlapped);

                    Console.WriteLine("So far " + this.pack.Count + " card(s) have been shuffled.");
                }
                // If any cards are left, just stick them back into the pack so we dont miss any.
                if (left.Count > 0)
                {
                    this.pack.AddRange(left);
                    Console.WriteLine("We couldn't shuffle " + left.Count + " card(s). So added them to the Pack.");
                }    
                else if (right.Count > 0)
                {
                    this.pack.AddRange(right);
                    Console.WriteLine("We couldn't shuffle " + right.Count + " card(s). So added them to the Pack.");
                }
                else
                {

                }
                Console.WriteLine("Shuffle Complete.");
                return true;

            }
            else
            {
                Console.WriteLine("No shuffle performed, or invalid shuffle type.");
                return false;
            }
        }

        public Card Deal()
        {
            if (this.pack.Count > 0)
            {
                Console.WriteLine("Card Dealt: " + this.pack.ElementAt(0));
                this.pack.Remove(this.pack.ElementAt(0));
                Console.WriteLine("Only " + this.pack.Count + " cards remain in the pack.");
                return this.pack.ElementAt(0);
            }
            else
            {
                Console.WriteLine("You're out of cards.");
                return null;
            }
        }
        public List<Card> DealCard(int amount)
        {
            if (amount <= 0 || amount > pack.Count)
            {
                Console.WriteLine("I can't deal negative cards, or more cards than you have in the pack!");
                return null;
            }
            else
            {
                Console.WriteLine("Dealing " + amount + " card(s)...");
                List<Card> cards = new List<Card>();
                for (int i = 0; i < amount; i++)
                {
                    cards.Add(pack[pack.Count - 1]);
                    Console.WriteLine(cards.ElementAt(i));
                    pack.RemoveAt(pack.Count - 1);
                }
                Console.WriteLine("There are " + pack.Count + " card(s) left in the pack.");
                return cards;
            }
        }
        public void PrintPack()
        {
            Console.WindowWidth = 100;
            int counter = 0;
            foreach (Card card in this.pack)
            {
                Console.Write(card.ToString());
                counter++;
                if (counter % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("There are " + this.pack.Count + " cards in the pack. Press any key to continue.");
            Console.ReadLine();
        }
    }
}

