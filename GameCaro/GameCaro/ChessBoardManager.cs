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
        private List<Player> player;
        private TextBox playername;
        private PictureBox playerPicture;
        private List<List<Button>> matrix;

        public int CurrentPlayer;
        public List<Player> Player { get => player; set => player = value; }
        public TextBox Playername { get => playername; set => playername = value; }
        public PictureBox PlayerPicture { get => playerPicture; set => playerPicture = value; }
        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

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
            Matrix = new List<List<Button>>();
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                Matrix.Add(new  List<Button>());
                for (int j = 0; j <= Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };

                    Matrix[i].Add(btn);
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

            if (IsEndGame(btn))
            {
                EndGame();
            }
        }

        private Point GetPointChess(Button btn)
        {
            var Vertical = Convert.ToInt32(btn.Tag);
            var Horizonable = Matrix[Vertical].IndexOf(btn);

            var point = new Point(Horizonable, Vertical);
            return point;
        }
        private bool IsEndGame(Button btn)
        {
            return IsEndHorizonable(btn) || IsEndVertical(btn) || IsEndPrimary(btn) || IsEndSub(btn);
        }
        private void EndGame()
        {
            MessageBox.Show("End Game");
        }
        private bool IsEndHorizonable(Button btn)
        {
            var point = GetPointChess(btn);
            int CountLeft = 0;
            for (int i = point.X; i >=0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                    CountLeft++;
                else
                    break;
            }
            int CountRight = 0;
            for (int i = point.X+1; i < Cons.CHESS_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                    CountRight++;
                else
                    break;
            }
            return CountLeft+CountRight == 5;
        }
        private bool IsEndVertical(Button btn)
        {
            var point = GetPointChess(btn);
            int CountLeft = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                    CountLeft++;
                else
                    break;
            }
            int CountRight = 0;
            for (int i = point.Y + 1; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                    CountRight++;
                else
                    break;
            }
            return CountLeft + CountRight == 5;
        }
        private bool IsEndPrimary(Button btn)
        {
            var point = GetPointChess(btn);
            int CountTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y -i< 0)
                    break;
                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                    CountTop++;
                else
                    break;
            }
            int CountBottom = 0;
            for (int i = 1; i <= Cons.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.X + i >= Cons.CHESS_BOARD_WIDTH || point.Y +i>=Cons.CHESS_BOARD_HEIGHT)
                    break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                    CountBottom++;
                else
                    break;
            }
            return CountTop + CountBottom == 5;
        }
        private bool IsEndSub(Button btn)
        {
            var point = GetPointChess(btn);
            int CountTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > Cons.CHESS_BOARD_WIDTH || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                    CountTop++;
                else
                    break;
            }
            int CountBottom = 0;
            for (int i = 1; i <= Cons.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.X - i <0 || point.Y + i >= Cons.CHESS_BOARD_HEIGHT)
                    break;
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                    CountBottom++;
                else
                    break;
            }
            return CountTop + CountBottom == 5;
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
