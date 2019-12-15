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
        public Game game { get; set; }
        public static Placement nextP;

        Dictionary<Button, Placement> buttonsPlacements = new Dictionary<Button, Placement>();

        private bool gameStarted = false;
        private int gameMode = 0;

        public AJJP_TicTacToe()
        {
            InitializeComponent();
        }

        private void AJJP_TicTacToe_Load(object sender, EventArgs e)
        {
            //Loads the different button placements into the dictionary
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game have been made by Anton, Jacob A, Jannie and Patrick 3.P. \nDelivered 20/12-2019.", "Info about game");
        }

        //Here begins the code for the game
        private void NextStep()
        {
            if (!game.IsGameDone) //Runs only if the game is still going
            {
                game.NextMove(); //Changes the turn
                TurnText.Text = "Turn: " + game.CurrentPlayer.ToString(); //Shows the next player

                UpdateForm(); //Updates the form with the right symbols
            }

            if (game.WhoWon() == null && game.IsGameDone) //If the game ends in a tie and is done
            {
                TurnText.Text = "Tie";
                gameStarted = false;
            }
            else if (game.WhoWon() != null) //If the game has a winner
            {
                TurnText.Text = game.WhoWon().ToString(); //Tells who won the game
                gameStarted = false;
            }
        }

        private void UpdateForm()
        {
            int index = 0;
            for (int i = 0; i < 3; i++) //Checks through the vertical placement spaces
            {
                for (int j = 0; j < 3; j++) //Checks through the horizontal placement spaces
                {
                    //Changes the buttons text element to the right symbol
                    buttonsPlacements.Keys.ToArray()[index].Text = game[i,j].ToString();
                    index++;
                }
            }
        }

        private void Continue_btn_Click(object sender, EventArgs e)
        {
            if (gameStarted)
            {
                if (gameMode == 2 && game.CurrentPlayer != Symbol.X)
                {
                    NextStep();
                }
                else if (gameMode == 3)
                {
                    NextStep();
                }
            }
        }

        private void GameModeChosen()
        {
            Restart_btn.Visible = true;
            Continue_btn.Visible = true;
            Board.Visible = true;
            Mode1.Visible = false;
            Mode2.Visible = false;
            Mode3.Visible = false;
        }

        private void playerVsPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameMode = 1; //Sets the gamemode
            Mode.Text = "Player vs. Player";

            GameModeChosen();
            Continue_btn.Visible = false;
            //Sets up the players
            GUIPlayer player1 = new GUIPlayer();
            GUIPlayer player2 = new GUIPlayer();

            Game g = new Game(player1, player2); //Sets up and starts the game
            game = g; //Sets the game 
            gameStarted = true; //Sets the game to be started
            TurnText.Text = "Turn: " + game.CurrentPlayer; //Shows the starting player

            //NextStep();
            UpdateForm(); //Updates the form
        }

        private void playerVsAIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameMode = 2;
            Mode.Text = "Player vs. AI";

            GameModeChosen();

            GUIPlayer player = new GUIPlayer();
            UffeSmarterAIPlayer AI = new UffeSmarterAIPlayer();
            Game g = new Game(player, AI);
            game = g;
            gameStarted = true;
            TurnText.Text = "Turn: " + game.CurrentPlayer; //Shows the starting player

            //NextStep();
            UpdateForm();
        }

        private void AIVsAIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameMode = 3;
            Mode.Text = "AI vs. AI";

            GameModeChosen();

            //Creates the AI that will be playing
            UffeSmarterAIPlayer Ai = new UffeSmarterAIPlayer();
            UffeAIPlayer AIDumb = new UffeAIPlayer();

            Game g = new Game(AIDumb, Ai); //Creates the game with the AI
            game = g; 
            gameStarted = true;
            TurnText.Text = "Turn: " + game.CurrentPlayer; //Shows the starting player

            //NextStep();
            UpdateForm();
        }

        private void Restart_btn_Click(object sender, EventArgs e)
        {
            switch (gameMode)
            {
                case 1:
                    playerVsPlayerToolStripMenuItem_Click(sender, e);
                    break;
                case 2:
                    playerVsAIToolStripMenuItem_Click(sender, e);
                    break;
                case 3:
                    AIVsAIToolStripMenuItem_Click(sender, e);
                    break;
                default:
                    TurnText.Text = "Choose a game (under file)";
                    break;
            }
        }

        private void A1_btn_Click(object sender, EventArgs e)
        {
            if (gameStarted)
            {
                Placement p = buttonsPlacements[(Button)sender];
                if (game.IsLegalMove(p))
                {
                    nextP = p;
                    NextStep();
                }
            }
        }

        private void Mode1_Click(object sender, EventArgs e)
        {
            playerVsPlayerToolStripMenuItem_Click(sender, e);
        }

        private void Mode2_Click(object sender, EventArgs e)
        {
            playerVsAIToolStripMenuItem_Click(sender, e);
        }

        private void Mode3_Click(object sender, EventArgs e)
        {
            AIVsAIToolStripMenuItem_Click(sender, e);
        }
    }
}
