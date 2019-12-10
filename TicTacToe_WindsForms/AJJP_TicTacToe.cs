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

namespace TicTacToe_WindsForms
{
    public partial class AJJP_TicTacToe : Form
    {
        Dictionary<Button, Placement> buttonsPlacements = new Dictionary<Button, Placement>();

        public AJJP_TicTacToe()
        {
            InitializeComponent();
        }

        private void AJJP_TicTacToe_Load(object sender, EventArgs e)
        {
            Placement pA1 = new Placement(0, 0);
            Placement pA2 = new Placement(0, 1);
            Placement pA3 = new Placement(0, 2);
            Placement pB1 = new Placement(1, 0);
            Placement pB2 = new Placement(1, 1);
            Placement pB3 = new Placement(1, 2);
            Placement pC1 = new Placement(2, 0);
            Placement pC2 = new Placement(2, 1);
            Placement pC3 = new Placement(2, 2);

            buttonsPlacements[A1_btn] = pA1;
            buttonsPlacements[A2_btn] = pA2;
            buttonsPlacements[A3_btn] = pA3;
            buttonsPlacements[B1_btn] = pB1;
            buttonsPlacements[B2_btn] = pB2;
            buttonsPlacements[B3_btn] = pB3;
            buttonsPlacements[C1_btn] = pC1;
            buttonsPlacements[C2_btn] = pC2;
            buttonsPlacements[C3_btn] = pC3;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void RunGame(Game g)
        {
            while(!g.IsGameDone)
            {
                //Starts the game
                TurnText.Text = "Turn: " + g.CurrentPlayer; //Shows the starting player
                g.NextMove(); //changes the turn

                //Updates the form with the right symbols
                UpdateForm(g);
            }
            if (g.WhoWon() == null) //If the game ends in a tie
            {
                TurnText.Text = "Tie";
            }
            else
            {
                //Tells who won the game (in a weird buggy way)
                TurnText.Text = g.WhoWon().ToString();
            }
        }

        private void UpdateForm(Game g)
        {
            int index = 0;
            for (int i = 0; i < 3; i++) //Checks through the vertical placement spaces
            {
                for (int j = 0; j < 3; j++) //Checks through the horizontal placement spaces
                {
                    //Changes the buttons text element to the right symbol
                    buttonsPlacements.Keys.ToArray()[index].Text = g[i,j].ToString();
                    index++;
                }
            }
        }

        private void A1_btn_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AIVsAIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UffeSmarterAIPlayer Ai = new UffeSmarterAIPlayer();
            UffeAIPlayer AIDumb = new UffeAIPlayer();
            Game g = new Game(AIDumb, Ai);
            RunGame(g);
        }

        private void playerVsAIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game have been made by Anton, Jacob A, Jannie and Patrick 3.P. \nDelivered 20/12-2019.", "Info about game");
        }
    }
}
