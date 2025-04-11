namespace chessLogic;
public abstract class Pieces
{
    public abstract PieceType Type { get; }
    public abstract Player color { get; }
    public bool hasMoved { get; set; } = false;
    public string PieceImage { get; set; }

    public abstract Pieces Copy();
}
