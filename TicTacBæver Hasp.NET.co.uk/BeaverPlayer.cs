using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe;

namespace TicTacBæver_Hasp.NET.co.uk
{

    public class BeaverPlayer : IPlayer
    {
        public static Placement nextMove;

        public Placement NextMove(Game game)
        {
            return nextMove;
        }
    }
}
