using System.Collections.Generic;
using System.Linq;

namespace SnakeLibrary
{
    public class Snake
    {
        private bool _directionChanged;

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
            if (!_directionChanged)
            {
                if (MoveDirection != newMoveDirection &&
                    !IsReverseDirections(MoveDirection, newMoveDirection))
                {
                    MoveDirection = newMoveDirection;
                    _directionChanged = true;
                }
            }

            return MoveDirection;
        }

        public void Move()
        {
            _directionChanged = false;
            var head = BodyCells.First;
            var oldCords = new Cell(head.Value);
            head.Value = GetNextHeadPosition();//head move

            MoveBody(head, oldCords);
        }

        public Cell GetNextHeadPosition()
        {
            int xIncrement = 0;
            int yIncrement = 0;
            switch (MoveDirection)
            {
                case MoveDirection.Up:
                    yIncrement = -1;
                    break;
                case MoveDirection.Down:
                    yIncrement = 1;
                    break;
                case MoveDirection.Left:
                    xIncrement = -1;
                    break;
                case MoveDirection.Right:
                    xIncrement = 1;
                    break;
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

            var selfCollision = BodyCells
                .Skip(1)
                .Any(bodyPart =>
                    bodyPart.Equals(headCell));

            return !selfCollision;
        }

        public void EatApple(Cell cell)
        {
            BodyCells.AddFirst(new Cell(cell));
        }

        private bool IsReverseDirections(MoveDirection a, MoveDirection b)
        {
            return (a == MoveDirection.Up && b == MoveDirection.Down) ||
                    (a == MoveDirection.Down && b == MoveDirection.Up) ||
                    (a == MoveDirection.Left && b == MoveDirection.Right) ||
                    (a == MoveDirection.Right && b == MoveDirection.Left);
        }

        private void MoveBody(LinkedListNode<Cell> head, Cell oldCords)
        {
            head = head.Next;
            while (head != null)
            {
                var tempCords = new Cell(head.Value);
                head.Value = oldCords;
                oldCords = tempCords;
                head = head.Next;
            }
        }
    }
}
