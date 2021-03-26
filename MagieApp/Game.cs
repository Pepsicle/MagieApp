using System;
using System.Collections.Generic;
using System.Text;

namespace MagieApp
{
    class Game
    {
        public Game(int width)
        {
            Width = width;
            GridList = new List<Row>();
            Rows = new List<Row>();
            for (int i = 0; i < Width; i++)
            {
                Rows.Add(new Column(Width));
            }
        }

        private int Width { get; set; }
        private List<Row> GridList { get; set; }
        private List<Row> Rows { get; set; }


    }
}
