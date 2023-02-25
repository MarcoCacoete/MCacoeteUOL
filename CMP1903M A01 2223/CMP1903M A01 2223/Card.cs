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
            string valueStr;
        switch (Value)
        {
            case 1:
                valueStr = "A";
                break;
            case 10:
                valueStr = "X";
                break;
            case 11:
                valueStr = "J";
                break;
            case 12:
                valueStr = "Q";
                break;
            case 13:
                valueStr = "K";
                break;
            default:
                valueStr = Value.ToString();
                break;
        }
        string suitStr;
        switch (Suit)
        {
            case 0:
                suitStr = "♠";
                break;
            case 1:
                suitStr = "♦";
                break;
            case 2:
                suitStr = "♥";
                break;
            case 3:
                suitStr = "♣";
                break;
            default:
                suitStr = "?";
                break;
        }
        return string.Format(@"
┌───────┐
│{0}{1}{2}    │
│       │
│   {3}   │
│       │
│   {2}{1}{0} │
└───────┘", valueStr.PadRight(1), suitStr, valueStr.PadLeft(1), suitStr);

        /* if (Suit == 0)
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
         else return "Whoops";*/
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
