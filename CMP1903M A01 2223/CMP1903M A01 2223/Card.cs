using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        private int Value { get; set; }
        private int Suit { get; set; }
        public override string ToString()
        {
            if (Suit == 0)
            {
                if (Value == 1)
                    return "Card: Ace ♠";
                else if (Value == 11)
                    return "Card: Jack ♠";
                else if (Value == 12)
                    return "Card: Queen ♠";
                else if (Value == 13)
                    return "Card: King ♠";
                else
                    return "Card: " + Value + "♠";
            }
            else if (Suit == 1)
            {
                if (Value == 1)
                    return "Card: Ace ♥";
                else if (Value == 11)
                    return "Card: Jack ♥";
                else if (Value == 12)
                    return "Card: Queen ♥";
                else if (Value == 13)
                    return "Card: King ♥";
                else
                    return "Card: " + Value + "♥";
            }
            else if (Suit == 2)
            {
                if (Value == 1)
                    return "Card: Ace ♦";
                else if (Value == 11)
                    return "Card: Jack ♦";
                else if (Value == 12)
                    return "Card: Queen ♦";
                else if (Value == 13)
                    return "Card: King ♦";
                else
                    return "Card: " + Value + "♦";
            }
            else if (Suit == 3)
            {
                if (Value == 1)
                    return "Card: Ace ♣";
                else if (Value == 11)
                    return "Card: Jack ♣";
                else if (Value == 12)
                    return "Card: Queen ♣";
                else if (Value == 13)
                    return "Card: King ♣";
                else
                    return "Card: " + Value + "♣";
            }
            else return "Whoops";
        }
        public Card(int cardVal, int suitVal)
        {
            Value = cardVal;
            Suit = suitVal;
        }
        
    }
    public static class CardExtension
    {
        public static void Swap<T>(this List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
