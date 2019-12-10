using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe;


namespace TicTacToeWithGUI
{
    public partial class PVP : Form
    {
        public static Placement input;
        Game g;
        

        static void Initializegame()
        {
           
        }
        public PVP()
        {
            InitializeComponent();
            
        }
        private string MakeSymbolPretty(int x, int y)
        {
            if (g[x, y] == Symbol.N)
            {
                return " ";
            }
            else
            {
                return g[x, y].ToString();
            }
        }
        private void UpdateButtons()
        {            
            _00.Text = MakeSymbolPretty(0, 0);
            _01.Text = MakeSymbolPretty(0, 1);
            _02.Text = MakeSymbolPretty(0, 2);
            _10.Text = MakeSymbolPretty(1, 0);
            _11.Text = MakeSymbolPretty(1, 1);
            _12.Text = MakeSymbolPretty(1, 2);
            _20.Text = MakeSymbolPretty(2, 0);
            _21.Text = MakeSymbolPretty(2, 1);
            _22.Text = MakeSymbolPretty(2, 2);
        }
        public void Button1_Click(object sender, EventArgs e)
        {
           
        }

        public void Startgamepvp_Click(object sender, EventArgs e)
        {

        }

        public void Button9_Click(object sender, EventArgs e)
        {
            input = new Placement(0, 0);
            if (g.IsLegalMove(input))
            {
                g.NextMove();
                UpdateButtons();
                PlayerTurn();
                CheckWin();
            }


        }
        private void CheckWin()
        {
            if (g.IsGameDone)
            {
                g.NextMove();
                win.Text = g.CurrentPlayer + " won the game";                
            }


        }
        private void PlayerTurn()
        {
            playerturn.Text = g.CurrentPlayer.ToString();
        }

            private void PVP_Load(object sender, EventArgs e)
        {
            IPlayer p1 = new GUIHumanPlayer();
            IPlayer p2 = new GUIHumanPlayer();
            g = new Game(p1,p2);
            PlayerTurn();
        }

        private void _11_Click(object sender, EventArgs e)
        {
            input = new Placement(1,1);
            if (g.IsLegalMove(input))
            {
                g.NextMove();
                UpdateButtons();
                PlayerTurn();
                CheckWin();
            }
        }

        private void _01_Click(object sender, EventArgs e)
        {
            input = new Placement(0, 1);
            if (g.IsLegalMove(input))
            {
                g.NextMove();
                UpdateButtons();
                PlayerTurn();
                CheckWin();
            }
        }

        private void _02_Click(object sender, EventArgs e)
        {
            input = new Placement(0, 2);
            if (g.IsLegalMove(input))
            {
                g.NextMove();
                UpdateButtons();
                PlayerTurn();
                CheckWin();
            }
        }

        private void _10_Click(object sender, EventArgs e)
        {
            input = new Placement(1, 0);
            if (g.IsLegalMove(input))
            {
                g.NextMove();
                UpdateButtons();
                PlayerTurn();
                CheckWin();
            }
        }

        private void _12_Click(object sender, EventArgs e)
        {
            input = new Placement(1, 2);
            if (g.IsLegalMove(input))
            {
                g.NextMove();
                UpdateButtons();
                PlayerTurn();
                CheckWin();
            }
        }

        private void _20_Click(object sender, EventArgs e)
        {
            input = new Placement(2, 0);
            if (g.IsLegalMove(input))
            {
                g.NextMove();
                UpdateButtons();
                PlayerTurn();
                CheckWin();
            }
        }

        private void _21_Click(object sender, EventArgs e)
        {
            input = new Placement(2, 1);
            if (g.IsLegalMove(input))
            {
                g.NextMove();
                UpdateButtons();
                PlayerTurn();
                CheckWin();
            }
        }

        private void _22_Click(object sender, EventArgs e)
        {
            input = new Placement(2, 2);
            if (g.IsLegalMove(input))
            {
                g.NextMove();
                UpdateButtons();
                PlayerTurn();
                CheckWin();
            }
        }
    }
}
