using System;
using System.Collections.Generic;
using System.Text;

namespace MagieApp
{
    public class Game
    {
        public List<Row> Rows { get; private set; }
        public int Width { get; set; }

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
                PrintGrid(Rows, true);
            }
            Console.WriteLine("");
            Console.WriteLine("In which row is your card:");
            Console.WriteLine("");
            int chosenRow = Int32.Parse(Console.ReadLine()) - 1;
            List<Card> ShuffledCards = deck.ClearTable(Rows, chosenRow);
            Console.WriteLine("");
            Console.WriteLine("1234");
            Console.WriteLine("vvvv");
            Console.WriteLine("");
            if (HandoutCards(ShuffledCards))
            {
                PrintGrid(Rows, false);
            }
            Console.WriteLine("");
            Console.WriteLine("In which column is your card?");
            Console.WriteLine("");
            int chosenColumn = Int32.Parse(Console.ReadLine()) - 1;
            string answer = deck.GetAnswer(Rows, chosenColumn);
            Console.WriteLine("");
            Console.WriteLine("The card you chose was: " + answer);
        }

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

        public void PrintGrid(List<Row> rows, bool displayRowNumber)
        {
            int rowNumber = 1;
            foreach (Row row in rows)
            {
                string print = "";
                foreach (var card in row.Cards)
                {
                    print += card.Value;
                }
                if (displayRowNumber == true)
                {
                    Console.WriteLine(rowNumber + ": " + print);
                } 
                else
                {
                    Console.WriteLine(print);
                }
                rowNumber++;
            }
        }



    }
}
