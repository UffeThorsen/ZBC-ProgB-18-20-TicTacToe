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
        static void Initializegame()
        {
            IPlayer p1 = new ConsoleHumanPlayer();
            IPlayer p2 = new ConsoleHumanPlayer();
            Game g = new Game(p1, p2);

        }
        public PVP()
        {
            InitializeComponent();
            
        }

        public void Button1_Click(object sender, EventArgs e)
        {

        }

        public void Startgamepvp_Click(object sender, EventArgs e)
        {

        }

        public void Button9_Click(object sender, EventArgs e)
        {
            
        }
    }
}
