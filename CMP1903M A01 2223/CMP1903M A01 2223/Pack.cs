using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public List<Card> cardPack = new List<Card>();
        //constructor
        public Pack()
        {
            //Card[] pack = new Card[52]; //empty array with 52 spaces for 52 card objects 
            int packSize = -1; //packsize iterator variable, starts at -1 to fit in array
                               //without going out of index
            int suit = 0; //suit variable for second iteration

            // Card pack generator

            while (packSize < 51) // while loop lets it run until it fills a pack with 52 cards
            {

                while (suit < 4) //iterates for each of the 4 suits and creates suited cards until all 13 are in
                {
                    int suitCards = 0;
                    suit++;
                    while (suitCards < 13)
                    {

                        suitCards++;
                        // deck = deck.Append((suitCards)).ToArray();
                        //Card card = new Card(value, suit);

                        packSize++;                                   //counter iterator for packsize to stop operation when pack is complete
                                                                      // pack[packSize] = new Card(suitCards, suit);
                        cardPack.Add(new Card(suitCards, suit));


                        string testout = cardPack.ElementAt(packSize).ToString();
                        Console.WriteLine(testout);

                    }
                }
            }
            
        }

        static Random rnd = new Random();

        public bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            Console.WriteLine(this.cardPack.Count);

            List<Card> checksum = new List<Card>();

            int counter = 0;

            while (checksum.Count<52)
            {

                int r = rnd.Next(cardPack.Count);

                var value = cardPack[r];

                if (!checksum.Contains(value))
                {

                    cardPack.RemoveAt(r);

                    checksum.Add(value);

                    cardPack.Add(value);
                    
                    counter++;

                }

                else
                {
                    continue;
                }

               // string testout = cardPack.ElementAt(counter).ToString();
               // Console.WriteLine(testout);


            }

            foreach(int card in cardPack)
            {
                Console.WriteLine(cardPack[card]);
            }
            Console.WriteLine("I can shuffle now Dave");
            Console.ReadLine();
            return true;
            /* public static Card deal()
             {
                 //Deals one card

             }
             public static List<Card> dealCard(int amount)
             {
                 //Deals the number of cards specified by 'amount'
             }*/


        }
    }
}
      