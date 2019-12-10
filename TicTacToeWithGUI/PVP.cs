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

        public void Button1_Click(object sender, EventArgs e)
        {

        }

        public void Startgamepvp_Click(object sender, EventArgs e)
        {

        }

        public void Button9_Click(object sender, EventArgs e)
        {
            
        }

        private void PVP_Load(object sender, EventArgs e)
        {
            IPlayer p1 = new GUIHumanPlayer();
            IPlayer p2 = new GUIHumanPlayer();
            g = new Game(p1,p2);
        }

        private void _11_Click(object sender, EventArgs e)
        {
            input = new Placement(1,1);
            if (g.IsLegalMove(input))
            {
                g.NextMove();
            }
        }
    }
}
