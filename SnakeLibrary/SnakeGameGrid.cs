using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLibrary
{
    public class SnakeGameGrid : GameGrid
    {
        private Random random;

        public const int MinimalSize = 5;

        public delegate void Notify();
        public event Notify SnakeIsDead;

        public Cell Apple { get; private set; }
        public Snake Snake { get; private set; }

        private SnakeGameGrid(int size, Notify snakeIsDead) : base(size)
        {
            Snake = new Snake();
            SnakeIsDead += snakeIsDead;
            random = new Random();
            CreateApple();
        }

        public static SnakeGameGrid Initialize(
            int size,
            Notify snakeIsDead)
        {
            if (size >= MinimalSize)
            {
                return new SnakeGameGrid(size, snakeIsDead);
            }

            throw new ArgumentException("Size should be greater than zero!");
        }

        public void Move()
        {
            if (!Snake.IsAlive(FieldSize))
            {
                SnakeIsDead?.Invoke();
                return;
            }

            if (Snake.GetNextHeadPosition().Equals(Apple))
            {
                Snake.EatApple(Apple);
                CreateApple();
            }
            else
            {
                Snake.Move();
            }
        }

        private void CreateApple()
        {
            Cell appleCell;
            do
            {
                appleCell = new Cell
                {
                    X = random.Next(0, FieldSize),
                    Y = random.Next(0, FieldSize)
                };
            } while (Snake.BodyCells
                .Any(x => x.Equals(appleCell)));

            Apple = appleCell;
        }
    }
}
