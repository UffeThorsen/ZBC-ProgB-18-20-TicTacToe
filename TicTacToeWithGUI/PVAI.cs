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
    public partial class PVAI : Form
    {
        public Game g;
        public PVAI()
        {
            InitializeComponent();
        }
        private void PlayerTurn()
        {
            pt.Text = g.CurrentPlayer.ToString();
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
        private void CheckWin()
        {
            if (g.IsGameDone)
            {
                win.Text = g.CurrentPlayer + " won the game";
                whitecover.Visible = true;
                mm.Visible = true;

            }
        }      
        
            private void UpdateButtons()
        {
            g.NextMove();   
            
            __00.Text = MakeSymbolPretty(0, 0);
            __01.Text = MakeSymbolPretty(0, 1);
            __02.Text = MakeSymbolPretty(0, 2);
            __10.Text = MakeSymbolPretty(1, 0);
            __11.Text = MakeSymbolPretty(1, 1);
            __12.Text = MakeSymbolPretty(1, 2);
            __20.Text = MakeSymbolPretty(2, 0);
            __21.Text = MakeSymbolPretty(2, 1);
            __22.Text = MakeSymbolPretty(2, 2);
        }
       

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }        

        private void PVAI_Load(object sender, EventArgs e)
        {
            IPlayer p1 = new UffeAIPlayer();
            IPlayer p2 = new GUIHumanPlayer();
            g = new Game(p1, p2);            
            UpdateButtons();
            PlayerTurn();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PlayerInputHolder.input = new Placement(0, 0);
            if (g.IsLegalMove(PlayerInputHolder.input))
            {
                g.NextMove();
                UpdateButtons();
                PlayerTurn();
                
            }
        }

        private void __01_Click(object sender, EventArgs e)
        {
            PlayerInputHolder.input = new Placement(0, 1);
            if (g.IsLegalMove(PlayerInputHolder.input))
            {
                g.NextMove();
                UpdateButtons();
                PlayerTurn();
                CheckWin();
            }
        }

        private void __02_Click(object sender, EventArgs e)
        {
            PlayerInputHolder.input = new Placement(0, 2);
            if (g.IsLegalMove(PlayerInputHolder.input))
            {
                g.NextMove();
                UpdateButtons();
                PlayerTurn();
                CheckWin();
            }
        }

        private void __10_Click(object sender, EventArgs e)
        {
            PlayerInputHolder.input = new Placement(1, 0);
            if (g.IsLegalMove(PlayerInputHolder.input))
            {
                g.NextMove();
                UpdateButtons();
                PlayerTurn();
                CheckWin();
            }
        }

        private void __11_Click(object sender, EventArgs e)
        {
            PlayerInputHolder.input = new Placement(1, 1);
            if (g.IsLegalMove(PlayerInputHolder.input))
            {
                g.NextMove();
                UpdateButtons();
                PlayerTurn();
                CheckWin();
            }
        }

        private void __12_Click(object sender, EventArgs e)
        {
            PlayerInputHolder.input = new Placement(1, 2);
            if (g.IsLegalMove(PlayerInputHolder.input))
            {
                g.NextMove();
                UpdateButtons();
                PlayerTurn();
                CheckWin();
            }
        }

        private void __20_Click(object sender, EventArgs e)
        {
            PlayerInputHolder.input = new Placement(2, 0);
            if (g.IsLegalMove(PlayerInputHolder.input))
            {
                g.NextMove();
                UpdateButtons();
                PlayerTurn();
                CheckWin();
            }
        }

        private void __21_Click(object sender, EventArgs e)
        {
            PlayerInputHolder.input = new Placement(2, 1);
            if (g.IsLegalMove(PlayerInputHolder.input))
            {
                g.NextMove();
                UpdateButtons();
                PlayerTurn();
                CheckWin();
            }
        }

        private void __22_Click(object sender, EventArgs e)
        {
            PlayerInputHolder.input = new Placement(2, 2);
            if (g.IsLegalMove(PlayerInputHolder.input))
            {
                g.NextMove();
                UpdateButtons();
                PlayerTurn();
                CheckWin();
            }
        }

        private void Pt_Click(object sender, EventArgs e)
        {

        }

        private void Mm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Startscreen sc = new Startscreen();
            sc.ShowDialog();
            this.Close();
        }
    }
}
