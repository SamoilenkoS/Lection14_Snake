using System.Collections.Generic;

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
                    Y = 0,
                    State = CellState.Snake
                });
            }

            BodyCells.First.Value.State = CellState.Head;
            MoveDirection = MoveDirection.Right;
        }

        public void Move()
        {
            if(MoveDirection == MoveDirection.Right)
            {
                var bodyPart = BodyCells.First;
                while(bodyPart != null)
                {
                    bodyPart.Value.X += 1;
                    bodyPart = bodyPart.Next;
                }
            }
        }
    }
}
