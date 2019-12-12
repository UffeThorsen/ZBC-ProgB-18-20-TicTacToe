using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe;

namespace TicTacToe_WindsForms
{
    class GUIPlayer : IPlayer
    {
        public Placement NextMove(Game game)
        {
            return AJJP_TicTacToe.nextP;
        }
    }
}
