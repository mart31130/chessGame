namespace chessLogic;

public class Bishop : Pieces
{
    public override PieceType Type => PieceType.Bishop;

    public override Player color { get; }

    public Bishop(Player color)
    {
        this.color = color;
    }

    public override Pieces Copy()
    {
        Bishop copy = new Bishop(color);
        copy.hasMoved = hasMoved;
        return copy;
    }
}
