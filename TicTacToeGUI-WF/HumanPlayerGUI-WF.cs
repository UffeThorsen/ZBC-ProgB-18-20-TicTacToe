using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TicTacToe;

namespace TicTacToeGUI_WF
{
    class HumanPlayerGUI_WF : IPlayer
    {
        private MainForm owner;
        public HumanPlayerGUI_WF(MainForm owner)
        {
            this.owner = owner;
        }

        public Placement NextMove(Game gameState)
        {
            return owner.LastChosen;
        }
    }
}
