using System;
using System.Collections.Generic;
using System.Text;
using CardValues = MagieApp.CardValues.Values;

namespace MagieApp
{
    class Card
    {
        public Card(object value)
        {
            this.Value = value;
            Marked = false;
            ChosenRow = false;
        }

        public int CardVal { get; set; }

        private object Value { get; set; }

        public bool Marked { get; set; }
        public bool ChosenRow { get; set; }


    }
}
