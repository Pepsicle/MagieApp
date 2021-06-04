using System;
using System.Collections.Generic;
using System.Text;
using CardValues = MagieApp.CardValues.Values;

namespace MagieApp
{
    public class Deck
    {
        private Random random;

        public Deck()
        {
        }

        public List<Card> DeckList { get; set; }

        public List<Card> ClearTable(List<Row> rows, int chosenRow)
        {
            MarkCards(rows, chosenRow);
            List<Card> ShuffledCards = new List<Card>();

            foreach (Row row in rows)
            {
                foreach (var card in row.Cards)
                {
                    ShuffledCards.Add(card);
                }
                row.Cards.Clear();
            }
            return Shuffle(ShuffledCards);
        }

        private void MarkCards(List<Row> rows, int chosenRow)
        {
            foreach (Card card in rows[chosenRow].Cards)
            {
                card.MarkCard();
            }
        }

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

        public List<Card> SecondHandout(List<Card> cards)
        {
            List<Card> SecondHandout = Shuffle(cards);
            return SecondHandout;
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

        public string GetAnswer(List<Row> rows, int chosenColumn)
        {
            foreach (Row row in rows)
            {
                if (row.Cards[chosenColumn].Marked == true)
                {
                    {
                        return row.Cards[chosenColumn].Value.ToString();
                    }
                }
                else if (!row.Cards[chosenColumn].Marked == true)
                {
                    return "There was a problem";
                }
            }
            return "There was a problem";
        }
    }
}
