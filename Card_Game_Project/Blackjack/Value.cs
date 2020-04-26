using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class Value
    {
        public static int CardValue(string cardID)
        {
            if (cardID == "2S" | cardID == "2H" | cardID == "2D" | cardID == "2C")
            {
                return 2;
            }
            else if (cardID == "3S" | cardID == "3H" | cardID == "3D" | cardID == "3C")
            {
                return 3;
            }
            else if (cardID == "4S" | cardID == "4H" | cardID == "4D" | cardID == "4C")
            {
                return 4;
            }
            else if (cardID == "5S" | cardID == "5H" | cardID == "5D" | cardID == "5C")
            {
                return 5;
            }
            else if (cardID == "6S" | cardID == "6H" | cardID == "6D" | cardID == "6C")
            {
                return 6;
            }
            else if (cardID == "7S" | cardID == "7H" | cardID == "7D" | cardID == "7C")
            {
                return 7;
            }
            else if (cardID == "8S" | cardID == "8H" | cardID == "8D" | cardID == "8C")
            {
                return 8;
            }
            else if (cardID == "9S" | cardID == "9H" | cardID == "9D" | cardID == "9C")
            {
                return 9;
            }
            else if (cardID == "10S" | cardID == "10H" | cardID == "10D" | cardID == "10C" | cardID == "JS" | cardID == "JH" | cardID == "JD" | cardID == "JC" |
                     cardID == "QS" | cardID == "QH" | cardID == "QD" | cardID == "QC" | cardID == "KS" | cardID == "KH" | cardID == "KD" | cardID == "KC")
            {
                return 10;
            }
            else if (cardID == "AS" | cardID == "AH" | cardID == "AD" | cardID == "AC")
            {
                return 11;
            }
            else
            {
                return 0;
            }
        }



    }
}
