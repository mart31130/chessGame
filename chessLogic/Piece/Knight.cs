namespace chessLogic;

public class Knight : Pieces
{
    public override PieceType Type => PieceType.Knight;

    public override Player color { get; }

    public Knight(Player color)
    {
        this.color = color;
        PieceImage = color == Player.White ? @"C:\\Users\\mdaignan\\source\\repos\\chessGame\\chessGame\\Assets\\KnightW.png" : @"C:\\Users\\mdaignan\\source\\repos\\chessGame\\chessGame\\Assets\\KnightB.png";

    }

    public override Pieces Copy()
    {
        Knight copy = new Knight(color);
        copy.hasMoved = hasMoved;
        return copy;
    }
}
