namespace chessLogic;

public class Knight : Pieces
{
    public override PieceType Type => PieceType.Knight;

    public override Player color { get; }

    public Knight(Player color)
    {
        this.color = color;
    }

    public override Pieces Copy()
    {
        Knight copy = new Knight(color);
        copy.hasMoved = hasMoved;
        return copy;
    }
}
