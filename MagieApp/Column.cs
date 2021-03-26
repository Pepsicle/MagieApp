using System;
using System.Collections.Generic;
using System.Text;

namespace MagieApp
{
    class Column
    {
        public List<Row> Rows { get; private set; }
        private int width = 4;

        public Column(int width)
        {
            Rows = new List<Row>();
            for (int i = 0; i < width; i++)
            {
                Rows.Add(new Row());
            }
        }
    }
}
