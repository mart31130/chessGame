namespace chessLogic;

public class Rook : Pieces
{
    public override PieceType Type => PieceType.Rook;

    public override Player color { get; }

    public Rook(Player color)
    {
        this.color = color;
    }

    public override Pieces Copy()
    {
        Rook copy = new Rook(color);
        copy.hasMoved = hasMoved;
        return copy;
    }
}
