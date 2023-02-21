using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {     
        //constructor
        public  Pack()
        {           

            Card[] pack = new Card[52]; //empty array with 52 spaces for 52 card objects 


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
                            pack[packSize] = new Card(suitCards, suit);
                            string testout = pack[packSize].ToString();
                            Console.WriteLine(testout);
                       
                        }

                    }
                

                }

                // Card c = new Card(value, suit);


                /*foreach (Card card in deck)

                     try
                     {
                         Console.WriteLine(card.ToString());
                         // c.Card(value, suit);
                         //Console.WriteLine("[{0}]", string.Join(", ", deck));
                         //Console.WriteLine(suit);
                         Console.WriteLine(packSize);
                         Console.ReadLine();

                     }
                     catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                   }*/
                Console.ReadLine();

                    
                }

            }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle

            /*  if (shuffleType == 2)
              {


                  int[] shuffle()
                  {

                      for (int i = pack.Length; i > 1; i--)
                      {
                          int j = Random.Next(i);
                          int temp = cards[j];
                          cards[j] = cards[i - 1];
                          cards[i - 1] = temp;
                      }
                      return cards;
                  }

                  int[] deal(int N)
                  {
                      int[] result = new int[N];
                      Array.Copy(shuffle(), 0, result, N);
                      return result;
                  }
              }
                  }
                      public static Card deal()
                      {
                          //Deals one card

                      }
                      public static List<Card> dealCard(int amount)
                      {
                          //Deals the number of cards specified by 'amount'
                    */
            Console.WriteLine("I can shuffle now Dave");
            return true;
        }
    }
}


      