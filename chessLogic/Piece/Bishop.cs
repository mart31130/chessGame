namespace chessLogic;

public class Bishop : Pieces
{
    public override PieceType Type => PieceType.Bishop;

    public override Player color { get; }

    public Bishop(Player color)
    {
        this.color = color;
        PieceImage = color == Player.White ? @"C:\\Users\\mdaignan\\source\\repos\\chessGame\\chessGame\\Assets\\BishopW.png" : @"C:\\Users\\mdaignan\\source\\repos\\chessGame\\chessGame\\Assets\\BishopB.png";

    }

    public override Pieces Copy()
    {
        Bishop copy = new Bishop(color);
        copy.hasMoved = hasMoved;
        return copy;
    }
}
