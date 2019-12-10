using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGUI_WF
{
    public partial class MainForm : Form
    {
        private HumanPlayerGUI_WF p1;
        private HumanPlayerGUI_WF p2;
        private TicTacToe.Game game;
        public TicTacToe.Placement LastChosen { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private string SymbolToString(TicTacToe.Symbol s)
        {
            if(s == TicTacToe.Symbol.N)
            {
                return "";
            }
            else
            {
                return s.ToString();
            }
        }

        private void NewGame()
        {
            p1 = new HumanPlayerGUI_WF(this);
            p2 = new HumanPlayerGUI_WF(this);
            game = new TicTacToe.Game(p1, p2);
            UpdateSymbols();
        }

        private void UpdateSymbols()
        {
            button00.Text = SymbolToString(game[0, 0]);
            button01.Text = SymbolToString(game[0, 1]);
            button02.Text = SymbolToString(game[0, 2]);
            button10.Text = SymbolToString(game[1, 0]);
            button11.Text = SymbolToString(game[1, 1]);
            button12.Text = SymbolToString(game[1, 2]);
            button20.Text = SymbolToString(game[2, 0]);
            button21.Text = SymbolToString(game[2, 1]);
            button22.Text = SymbolToString(game[2, 2]);

            topLabel.Text = "Current player is: " + game.CurrentPlayer.ToString();
            if (game.IsGameDone)
            {
                string winningText = "Game is over\n      ";
                if(game.WhoWon() == null)
                {
                    winningText += "nobody";
                }else if(game.WhoWon() == p1)
                {
                    winningText += "X";
                }else if(game.WhoWon() == p2)
                {
                    winningText += "O";
                }
                bottomLabel.Text = winningText + " won!";
            }
            else
            {
                bottomLabel.Text = "";
            }
        }

        private void SharedButtonClicks()
        {
            if (!game.IsGameDone && game.IsLegalMove(LastChosen))
            {
                game.NextMove();
            }
            UpdateSymbols();
        }

        private void button00_Click(object sender, EventArgs e)
        {
            LastChosen = new TicTacToe.Placement(0, 0);
            SharedButtonClicks();
        }

        private void button01_Click(object sender, EventArgs e)
        {
            LastChosen = new TicTacToe.Placement(0, 1);
            SharedButtonClicks();
        }

        private void button02_Click(object sender, EventArgs e)
        {
            LastChosen = new TicTacToe.Placement(0, 2);
            SharedButtonClicks();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LastChosen = new TicTacToe.Placement(1, 0);
            SharedButtonClicks();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LastChosen = new TicTacToe.Placement(1, 1);
            SharedButtonClicks();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            LastChosen = new TicTacToe.Placement(1, 2);
            SharedButtonClicks();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            LastChosen = new TicTacToe.Placement(2, 0);
            SharedButtonClicks();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            LastChosen = new TicTacToe.Placement(2, 1);
            SharedButtonClicks();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            LastChosen = new TicTacToe.Placement(2, 2);
            SharedButtonClicks();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
