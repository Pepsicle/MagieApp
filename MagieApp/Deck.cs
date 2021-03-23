using System;
using System.Collections.Generic;
using System.Text;

namespace MagieApp
{
    class Deck
    {
        public Deck(List<Card> cards)
        {
            DeckList = cards;
        }

        public List<Card> DeckList { get; set; }

        public List<Card> Shuffle()
        {
            List<Card> ShuffledList = new List<Card>();

            return ShuffledList;
        }
    }
}
