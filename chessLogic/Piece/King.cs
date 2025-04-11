namespace chessLogic;

public class King : Pieces
{
    public override PieceType Type => PieceType.King;

    public override Player color { get; }

    public King(Player color)
    {
        this.color = color;
        PieceImage = color == Player.White ? @"C:\\Users\\mdaignan\\source\\repos\\chessGame\\chessGame\\Assets\\KingW.png" : @"C:\\Users\\mdaignan\\source\\repos\\chessGame\\chessGame\\Assets\\KingB.png";

    }

    public override Pieces Copy()
    {
        King copy = new King(color);
        copy.hasMoved = hasMoved;
        return copy;
    }
}
