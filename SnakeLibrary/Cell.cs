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

        public Cell()
        {

        }

        public Cell(Cell cell)
        {
            X = cell.X;
            Y = cell.Y;
        }

        public override bool Equals(object obj)
        {
            var cell = obj as Cell;
            if(cell != null)
            {
                return cell.X == X && cell.Y == Y;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
