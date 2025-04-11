namespace chessLogic
{
    public class Direction
    {

        public static Direction up = new Direction(-1, 0);
        public static Direction down = new Direction(1, 0);
        public static Direction right  = new Direction(0, 1);
        public static Direction left = new Direction(0, -1);

        public static Direction upRight = up + right;
        public static Direction upLeft = up + left;
        public static Direction downRight= down + right;
        public static Direction downLeft = down + right;

        public int RowDelta { get; }
        public int ColumnDelta { get; }
        public Direction(int rowDelta, int columnDelta)
        {
            RowDelta = rowDelta;
            ColumnDelta = columnDelta;
        }

        public static Direction operator + (Direction dir1, Direction dir2)
        {
            return new Direction(dir1.RowDelta + dir2.RowDelta, dir1.ColumnDelta + dir2.ColumnDelta);
        }

        public static Direction operator * (int scalar, Direction dir)
        {
            return new Direction(scalar * dir.RowDelta , scalar * dir.ColumnDelta );
        }
    }
}
