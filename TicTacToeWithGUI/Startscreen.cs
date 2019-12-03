using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeWithGUI
{
    public partial class Startscreen : Form
    {
        public Startscreen()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PVP pvp = new PVP();
            pvp.ShowDialog(); 
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AIVAI aivai = new AIVAI();
            aivai.ShowDialog();
            this.Close();
        }
    }
}
