using System.Collections.Generic;
using System.Linq;

namespace SnakeLibrary
{
    public class Snake
    {
        public LinkedList<Cell> BodyCells { get; private set; }
        public MoveDirection MoveDirection { get; private set; }

        public Snake()
        {
            BodyCells = new LinkedList<Cell>();
            for (int i = 0; i < SnakeGameGrid.MinimalSize; i++)
            {
                BodyCells.AddLast(new Cell
                {
                    X = SnakeGameGrid.MinimalSize - i - 1,
                    Y = 0
                });
            }

            MoveDirection = MoveDirection.Right;
        }

        public MoveDirection ChangeDirection(MoveDirection newMoveDirection)
        {
            if ((MoveDirection == MoveDirection.Up && newMoveDirection != MoveDirection.Down) ||
                (MoveDirection == MoveDirection.Down && newMoveDirection != MoveDirection.Up) ||
                (MoveDirection == MoveDirection.Left && newMoveDirection != MoveDirection.Right) ||
                (MoveDirection == MoveDirection.Right && newMoveDirection != MoveDirection.Left))
            {
                MoveDirection = newMoveDirection;
            }

            return MoveDirection;
        }

        public void Move()
        {
            var head = BodyCells.First;
            var oldCords = new Cell(head.Value);
            head.Value = GetNextHeadPosition();

            head = head.Next;
            while (head != null)
            {
                var tempCords = new Cell(head.Value);
                head.Value = oldCords;
                oldCords = tempCords;
                head = head.Next;
            }
        }

        public Cell GetNextHeadPosition()
        {
            int xIncrement = 0;
            int yIncrement = 0;
            if (MoveDirection == MoveDirection.Right)
            {
                xIncrement = 1;
            }
            else if (MoveDirection == MoveDirection.Left)
            {
                xIncrement = -1;
            }
            else if (MoveDirection == MoveDirection.Up)
            {
                yIncrement = -1;
            }
            else
            {
                yIncrement = 1;
            }

            return new Cell
            {
                X = BodyCells.First.Value.X + xIncrement,
                Y = BodyCells.First.Value.Y + yIncrement
            };
        }

        public bool IsAlive(int fieldSize)
        {
            var headCell = BodyCells.First.Value;

            var fieldCollision = headCell.X < 0 ||
                headCell.X >= fieldSize ||
                headCell.Y < 0 ||
                headCell.Y >= fieldSize;

            if (fieldCollision)
            {
                return false;
            }

            return
                !BodyCells
                .Skip(1)
                .Any(bodyPart =>
                    bodyPart.Equals(headCell));
        }

        public int EatApple(Cell cell)
        {
            BodyCells.AddFirst(new Cell(cell));

            return BodyCells.Count;
        }
    }
}
