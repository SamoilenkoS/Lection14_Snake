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
            if (obj is Cell cell)
            {
                return cell.X == X && cell.Y == Y;
            }

            return false;
        }

        public override int GetHashCode()
        {
            int hashCode = 1861411795;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();

            return hashCode;
        }
    }
}
