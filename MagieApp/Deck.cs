using System;
using System.Collections.Generic;
using System.Text;
using CardValues = MagieApp.CardValues.Values;

namespace MagieApp
{
    class Deck
    {
        private Random random;

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
                FirstHandoutList.Add(card);
            }

            return FirstHandoutList;
        }

        public List<Card> Shuffle(List<Card> OldList)
        {
            random = new Random();

            var count = OldList.Count;
            var last = count - 1;
            for (var cardnum = 0; cardnum < last; ++cardnum) 
            {
                var randomnum = random.Next(cardnum, count);
                var tmp = OldList[cardnum];
                OldList[cardnum] = OldList[randomnum];
                OldList[randomnum] = tmp;
            }

            OldList.Sort(delegate (Card x, Card y) {
                return x.Marked.CompareTo(y.Marked);
            });

            return OldList;
        }
    }
}
