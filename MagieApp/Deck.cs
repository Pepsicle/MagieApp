using System;
using System.Collections.Generic;
using System.Text;
using CardValues = MagieApp.CardValues.Values;

namespace MagieApp
{
    class Deck
    {
        public Deck(List<Card> cards)
        {
            DeckList = cards;
        }

        public List<Card> DeckList { get; set; }

        public List<Card> FirstHandout()
        {
            List<Card> FirstHandoutList = new List<Card>();
            var values = Enum.GetValues(typeof(CardValues.Values));
            foreach (var value in values)
            {
                Card card = new Card(value);
            }

            return FirstHandoutList;
        }

        public List<Card> Shuffle()
        {
            List<Card> ShuffledList = new List<Card>();

            return ShuffledList;
        }
    }
}
