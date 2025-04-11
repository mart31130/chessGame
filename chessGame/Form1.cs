using chessLogic;
using Microsoft.VisualBasic.ApplicationServices;

namespace chessGame
{
    public partial class Form1 : Form
    {
        private PictureBox[,] pieceImage = new PictureBox[8, 8];

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(800, 850);
            Icon = new Icon(@"C:\Users\mdaignan\source\repos\chessGame\chessGame\Assets\icon.ico");
            BackgroundImage = Image.FromFile(@"C:\Users\mdaignan\source\repos\chessGame\chessGame\Assets\Board.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            InitializeBoardUI();
            InitializeGame();
        }

        private void InitializeBoardUI()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    PictureBox pb = new PictureBox
                    {
                        Size = new Size(100, 100),
                        Location = new Point(col * 100, row * 100),
                        BackColor = Color.Transparent,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };

                    pieceImage[row, col] = pb;
                    Controls.Add(pb);
                }
            }
        }

        private GameState gameState;

        private void InitializeGame()
        {
            gameState = new GameState(Player.White, Board.Initial());
            DrawBoard(gameState.Board);
        }

        private void DrawBoard(Board board)
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Pieces piece = board[row, col];

                    if (piece != null && !string.IsNullOrEmpty(piece.PieceImage))
                    {
                        pieceImage[row, col].Image = Image.FromFile(piece.PieceImage);
                    }
                    else
                    {
                        pieceImage[row, col].Image = null;
                    }
                }
            }
        }




    }
}