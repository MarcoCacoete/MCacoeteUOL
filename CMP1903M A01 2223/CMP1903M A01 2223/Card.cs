using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public int Value { get; set; }
        public int Suit { get; set; }

        //constructor
        public Card(int value, int suit)
        {
            string top4 = Convert.ToString(value);

            if (value == 1)
            {
                top4 = "Ace";
            }
            if (value == 13)
            {
                top4 = "King";
            }


            if (value == 12)
            {
                top4 = "Queen";
            }


            if (value == 11)
            {
                top4 = "Jack";
            }


            Value = value;
            Suit = suit;

        }
    }
}
