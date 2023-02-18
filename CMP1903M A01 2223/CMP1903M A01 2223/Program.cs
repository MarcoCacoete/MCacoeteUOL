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
            int[] suits = new int[4] { 1, 2, 3, 4 };
            Card[] deck = new Card[53];

            int packSize = 0;

            int value = 0;
            int suit = 0;

            while (packSize < 52)
            {

                foreach (int i in suits)
                {
                    int suitCards = 0;
                    suit++;
                    while (suitCards < 13)
                    {

                        suitCards++;
                        // deck = deck.Append((suitCards)).ToArray();
                        //Card card = new Card(value, suit);

                        packSize++;
                        deck[packSize] = new Card(suitCards, suit);
                         string testout = deck[packSize].ToString();
                        Console.WriteLine(testout);
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
                }
            }
        }
    }
