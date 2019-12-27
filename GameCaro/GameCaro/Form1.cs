using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Form1 : Form
    {
        ChessBoardManager Control;
        public Form1()
        {
            InitializeComponent();
            this.Control = new ChessBoardManager(pnl1);
            Control.DrawChessBoard();
        }
    }
}
