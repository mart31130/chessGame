namespace chessLogic;

public class Pawn : Pieces
{
    public override PieceType Type => PieceType.Pawn;

    public override Player color { get; }

    public Pawn(Player color)
    {
        this.color = color;
    }

    public override Pieces Copy()
    {
        Pawn copy = new Pawn(color);
        copy.hasMoved = hasMoved;
        return copy;
    }
}
