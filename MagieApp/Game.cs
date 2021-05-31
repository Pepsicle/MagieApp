using System;
using System.Collections.Generic;
using System.Text;

namespace MagieApp
{
    public class Game
    {
        public List<Row> Rows { get; private set; }

        public Game(int width)
        {
            Width = width;
            Rows = new List<Row>();
            for (int i = 0; i < Width; i++)
            {
                Rows.Add(new Row());
            }
        }

        public void StartGame()
        {
            Deck deck = new Deck();
            List<Card> FirstHandoutCards = deck.FirstHandout();
            if (HandoutCards(FirstHandoutCards))
            {
                PrintGrid(Rows);
            }
            Console.WriteLine("In which row is your card:");
            int chosenRow = Int32.Parse(Console.ReadLine()) - 1;
            List<Card> ShuffledCards = deck.ClearTable(Rows, chosenRow);
            Console.WriteLine("1234");
            Console.WriteLine("vvvv");
            if (HandoutCards(ShuffledCards))
            {
                PrintGrid(Rows);
            }
        }

        //private bool MarkCards2(int chosenRow)
        //{
        //    foreach(Card card in Rows[chosenRow].Cards)
        //    {
        //        card.MarkCard(chosenRow);
        //    }
        //    return true;
        //}

        private bool HandoutCards(List<Card> cards)
        {
            foreach (var row in Rows)
            {
                for (int i = 0; i < Width; i++)
                {
                    cards[0].SetRow(i);
                    row.Cards.Add(cards[0]);
                    cards.RemoveAt(0);
                }
            }
            return true;
        }

        public void PrintGrid(List<Row> rows)
        {
            int rowNumber = 1;
            foreach (Row row in rows)
            {
                string print = "";
                foreach (var card in row.Cards)
                {
                    print += card.Value;
                }
                Console.WriteLine(rowNumber + ": " + print);
                rowNumber++;
            }
        }

        public int Width { get; set; }


    }
}
