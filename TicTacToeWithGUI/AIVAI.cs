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
    public partial class AIVAI : Form
    {
        public Game g;
        public AIVAI()
        {
            InitializeComponent();
        }

        private void AIVAI_Load(object sender, EventArgs e)
        {
            IPlayer p1 = new UffeAIPlayer();
            IPlayer p2 = new UffeAIPlayer();
            g = new Game(p1, p2);
            PlayerTurn();
            
        }
        private string MakeSymbolPretty(int x, int y)
        {
            if (g[x,y] == Symbol.N)
            {
                return " ";
            }
            else
            {
                return g[x,y].ToString();
            }
        }
        private void CheckWin()
        {
            if (g.IsGameDone)
            {
                win.Text = g.WhoWon() + " won the game";
                mainmenu.Visible = true;
            }
            

        }
        private void PlayerTurn()
        {
            pt.Text = g.CurrentPlayer.ToString();

        }
        private void UpdateButtons()
        {
            g.NextMove();
            CheckWin();
            _00.Text = MakeSymbolPretty(0,0);
            _01.Text = MakeSymbolPretty(0, 1);
            _02.Text = MakeSymbolPretty(0, 2);
            _10.Text = MakeSymbolPretty(1, 0);
            _11.Text = MakeSymbolPretty(1, 1);
            _12.Text = MakeSymbolPretty(1, 2);
            _20.Text = MakeSymbolPretty(2, 0);
            _21.Text = MakeSymbolPretty(2, 1);
            _22.Text = MakeSymbolPretty(2, 2);
        }

        private void _00_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UpdateButtons();
            PlayerTurn();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
           
        }

        private void Mainmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Startscreen sc = new Startscreen();
            sc.ShowDialog();
            this.Close();
        }

        private void Pt_Click(object sender, EventArgs e)
        {

        }
    }
}
