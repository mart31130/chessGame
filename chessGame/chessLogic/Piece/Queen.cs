namespace chessLogic
{
        public class Queen : Pieces
        {
            public override PieceType Type => PieceType.Queen;

            public override Player color { get; }

            public Queen(Player color)
            {
                this.color = color;
            }

            public override Pieces Copy()
            {
                Queen copy = new Queen(color);
                copy.hasMoved = hasMoved;
                return copy;
            }
        }
    }