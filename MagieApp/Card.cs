using System;
using System.Collections.Generic;
using System.Text;
using CardValues = MagieApp.CardValues.Values;

namespace MagieApp
{
    class Card
    {
        public Card(int value)
        {
            CardVal = value;
            Marked = false;
            ChosenRow = false;
        }

        public int CardVal { get; set; }
        public bool Marked { get; set; }
        public bool ChosenRow { get; set; }


    }
}
