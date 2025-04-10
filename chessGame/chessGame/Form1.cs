using Microsoft.VisualBasic.ApplicationServices;

namespace chessGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(800, 800);
            Icon = new Icon(@"C:\Users\mdaignan\source\repos\chessGame\chessGame\Assets\icon.ico");
            BackgroundImage = Image.FromFile(@"C:\Users\mdaignan\source\repos\chessGame\chessGame\Assets\Board.png");
            BackgroundImageLayout = ImageLayout.Stretch;
        }


    }
}
