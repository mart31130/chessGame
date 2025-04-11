namespace chessLogic
{
        public class Queen : Pieces
        {
            public override PieceType Type => PieceType.Queen;

            public override Player color { get; }

            public Queen(Player color)
            {
                this.color = color;
                PieceImage = color == Player.White ? @"C:\\Users\\mdaignan\\source\\repos\\chessGame\\chessGame\\Assets\\QueenW.png" : @"C:\\Users\\mdaignan\\source\\repos\\chessGame\\chessGame\\Assets\\QueenB.png";

        }

        public override Pieces Copy()
            {
                Queen copy = new Queen(color);
                copy.hasMoved = hasMoved;
                return copy;
            }
        }
    }