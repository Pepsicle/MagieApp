using System;
using System.Collections.Generic;
using System.Text;
using CardValues = MagieApp.CardValues.Values;

namespace MagieApp
{
    public class Card
    {
        public Card(object value)
        {
            this.Value = value;
            Marked = false;
            Row = 0;
            //ChosenRow = false;
        }

        public void MarkCard()
        {
            Marked = true;
        }

        public void SetRow(int row)
        {
            Row = row;
        }

        public int CardVal { get; set; }

        public object Value { get; set; }

        public bool Marked { get; set; }
        public int Row { get; set; }
        //public bool ChosenRow { get; set; }


    }
}
