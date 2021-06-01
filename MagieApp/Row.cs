using System;
using System.Collections.Generic;
using System.Text;

namespace MagieApp
{
    public class Row
    {
        public List<Card> Cards { get; set; }
        public Row()
        {
            Cards = new List<Card>();
        }
    }
}
