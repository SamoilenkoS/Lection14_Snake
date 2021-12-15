namespace SnakeLibrary
{
    public class GameGrid
    {
        public readonly Cell[,] Cells;

        protected GameGrid(int size)
        {
            Cells = new Cell[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Cells[i, j] = new Cell
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
