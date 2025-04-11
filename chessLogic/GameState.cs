namespace chessLogic
{
   public class GameState
    {
        public Board Board { get; }
        public Player currentPlayer { get; private set; }

        public GameState(Player player, Board board)
        {
            this.Board = board;
            this.currentPlayer = player;
        }
    }
}
