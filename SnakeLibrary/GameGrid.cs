namespace SnakeLibrary
{
    public class GameGrid
    {
        public readonly GridCell[,] Cells;

        public int FieldSize => Cells.GetLength(0);

        protected GameGrid(int size)
        {
            Cells = new GridCell[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Cells[i, j] = new GridCell
                    {
                        X = i,
                        Y = j,
                        State = CellState.Free
                    };
                }
            }
        }
    }
}
