using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLibrary
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CellState State { get; set; }
    }
}
