namespace chessLogic;

public class King : Pieces
{
    public override PieceType Type => PieceType.King;

    public override Player color { get; }

    public King(Player color)
    {
        this.color = color;
    }

    public override Pieces Copy()
    {
        King copy = new King(color);
        copy.hasMoved = hasMoved;
        return copy;
    }
}
