using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    static class Pack
    {
        public static List<Card> cardPack = new List<Card>();
        //constructor
        static Pack()
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

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            //Console.WriteLine(this.cardPack.Count);

            if (typeOfShuffle == 1)
            {

                List<Card> checksum = new List<Card>();

                int counter = -1;

                while (checksum.Count < 52)
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

                    string testout = cardPack.ElementAt(counter).ToString();
                    Console.WriteLine(testout);

                }

                foreach (Card card in cardPack)
                {
                    Console.WriteLine(card.ToString());
                }

                Console.WriteLine(cardPack.Count);

                Console.WriteLine("I can shuffle now Dave");

                Console.ReadLine();
            }

            if (typeOfShuffle == 2)
            {
                int riffleCounter = 5;

                while (riffleCounter > 0)
                {
                    riffle();
                    riffleCounter--;
                    void riffle()
                    {

                        int r = rnd.Next(0, 6);

                        int counter1 = 21 + r;
                        int counter2 = 52 - counter1;
                        int iterator = -1;

                        List<Card> leftHand = new List<Card>();
                        List<Card> rightHand = new List<Card>();

                        while (counter1 > 0)
                        {
                            iterator++;

                            leftHand.Add(cardPack[iterator]);

                            counter1--;
                        }

                        while (counter2 > 0)
                        {
                            iterator++;

                            rightHand.Add(cardPack[iterator]);

                            counter2--;
                        }
                        Console.WriteLine(iterator);
                        Console.WriteLine(leftHand.Count + rightHand.Count);
                        int iteratorLeft = 0;
                        int iteratorRight = 0;
                        iterator = 52;

                        while (iterator > 0)
                        {
                            int coinFlip = rnd.Next(0, 2);



                            if (leftHand.Count > 0)
                            {
                                if (coinFlip > 0)
                                {

                                    if (iteratorLeft != leftHand.Count)
                                    {


                                        cardPack.RemoveAt(0);
                                        cardPack.Add(leftHand[iteratorLeft]);
                                        iterator--;
                                        iteratorLeft++;
                                    }
                                }
                            }

                            if (rightHand.Count > 0)
                            {
                                if (coinFlip == 0)
                                {


                                    if (iteratorRight != rightHand.Count)
                                    {

                                        cardPack.RemoveAt(0);
                                        cardPack.Add(rightHand[iteratorRight]);
                                        iterator--;
                                        iteratorRight++;
                                    }
                                }
                            }
                        }
                        foreach (Card card in cardPack)
                        {
                            Console.WriteLine(card);
                        }
                        Console.WriteLine("count " + cardPack.Count);
                    }
                }
            }

            if (typeOfShuffle == 3)
            {
                Console.WriteLine("Your deck is not shuffled.");
            }

            
        return true;

        }

        static List<Card> dealtCards = new List<Card>();

        public static Card deal()
            {
            //Deals one card

            Card value = cardPack[0];


            cardPack.RemoveAt(0);

            dealtCards.Add(value);

            

            foreach (Card card in dealtCards)
            {
                Console.WriteLine(card.ToString());
            }
            
            return value;
            }
                
        public static  List<Card> dealCard(int amount)
            {
            
            //Deals the number of cards specified by 'amount'

            while (amount > 0)
            {
                
                Card value = cardPack[0];

                if (!dealtCards.Contains(value))
                {

                    cardPack.RemoveAt(0);

                    dealtCards.Add(value);
                    amount--;
                }

                else if (cardPack.Count == 0)
                {
                    Console.WriteLine("No more cards to be dealt.");
                }
               
            }
            foreach (Card card in dealtCards)
            {
                Console.WriteLine(card.ToString());
            }
            return dealtCards;
        } 


        
    }
}

      