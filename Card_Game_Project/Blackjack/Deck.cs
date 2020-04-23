using System;
using System.Collections.Generic;
using System.Text;
using static Blackjack.Card;

namespace Blackjack
{
    class Deck
    {
        const int numCards = 52;
        private Card[] deck;

        public Deck()
        {
            deck = new Card[numCards];
        }

        public Card[] GetDeck { get { return deck; } }

        public void CreateDeck()
        {
            int i = 0;
            foreach (SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach (VALUE n in Enum.GetValues(typeof(VALUE)))
                {
                    deck[i] = new Card { MySuit = s, MyNumber = n };
                    i++;
                }
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();
            Card temp;

            for (int shuffleTimes = 0; shuffleTimes < 1000; shuffleTimes++)
            {
                for (int i = 0; i < numCards; i++)
                {
                    int secondCardIndex = rand.Next(13);
                    temp = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp;
                }
            }
        }
    }
}
