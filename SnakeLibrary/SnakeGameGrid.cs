using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLibrary
{
    public class SnakeGameGrid : GameGrid
    {
        public const int MinimalSize = 3;
        public Snake Snake { get; private set; }

        private SnakeGameGrid(int size) : base(size)
        {
            Snake = new Snake();
            var head = Snake.BodyCells.First;
            while(head != null)
            {
                Cell snakePart = head.Value;
                Cells[snakePart.X, snakePart.Y].State =
                    snakePart.State;
                head = head.Next;
            }
        }

        public static SnakeGameGrid Initialize(int size)
        {
            if (size >= MinimalSize)
            {
                return new SnakeGameGrid(size);
            }

            throw new ArgumentException("Size should be greater than zero!");
        }

        public void Move()
        {
            Snake.Move();
            var head = Snake.BodyCells.First;
            while (head != null)
            {
                Cell snakePart = head.Value;
                Cells[snakePart.X, snakePart.Y].State =
                    snakePart.State;
                head = head.Next;
            }
        }
    }
}
