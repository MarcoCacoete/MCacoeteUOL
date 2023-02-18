using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public override string ToString()
        {
            return "Card: " + Value + " " + Suit;
        }
        public Card(int value, int suit)
       {
            
          
           Value = value;
           Suit = suit;

       }
   }
}
 