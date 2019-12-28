using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;

        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }

        public List<Player> Player { get => player; set => player = value; }
        public TextBox Playername { get => playername; set => playername = value; }
        public PictureBox PlayerPicture { get => playerPicture; set => playerPicture = value; }

        private List<Player> player;

        private TextBox playername;

        private PictureBox playerPicture;

        public int CurrentPlayer;
        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard, TextBox textname, PictureBox pictureplayer)
        {
            this.ChessBoard = chessBoard;
            this.Playername = textname;
            this.PlayerPicture = pictureplayer;
            this.player = new List<Player>
            {
                new Player("Player 1", Image.FromFile("C:\\Users\\DELL\\Downloads\\O.png")),
                new Player("Player 2", Image.FromFile("C:\\Users\\DELL\\Downloads\\X.png")),
            };
            this.CurrentPlayer = 0;
            ChangePlayer();
        }
        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j <= Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                    };
                    btn.Click += Btn_Click;
                    ChessBoard.Controls.Add(btn);
                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.CHESS_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackgroundImage != null)
                return;
            Mark(btn);
            ChangePlayer();
        }
        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
        }

        private void ChangePlayer()
        {
            Playername.Text = Player[CurrentPlayer].Name;
            PlayerPicture.Image = Player[CurrentPlayer].Mark;
        }
        
        #endregion
    }
}
