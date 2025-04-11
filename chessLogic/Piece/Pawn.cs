using static System.Net.Mime.MediaTypeNames;

namespace chessLogic;

public class Pawn : Pieces
{
    public override PieceType Type => PieceType.Pawn;

    public override Player color { get; }


    public Pawn(Player color)
    {
        this.color = color;
        PieceImage = color == Player.White ? @"C:\\Users\\mdaignan\\source\\repos\\chessGame\\chessGame\\Assets\\PawnW.png" : @"C:\\Users\\mdaignan\\source\\repos\\chessGame\\chessGame\\Assets\\PawnB.png";
    }

    public override Pieces Copy()
    {
        Pawn copy = new Pawn(color);
        copy.hasMoved = hasMoved;
        return copy;
    }
}
