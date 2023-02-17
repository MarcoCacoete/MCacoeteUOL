using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Program
    {
        static void Main(string[] args)
        {

            int packSize = 0;

            int value = 0;
            int suit = 0;

            while (packSize < 52)
            {


                Card c = new Card(value, suit);

                c.Card(value, suit);

                packSize++;
            }



        }
    }
}
