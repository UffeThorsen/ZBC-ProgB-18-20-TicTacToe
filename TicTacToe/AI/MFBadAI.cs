using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class MFBadAI : IPlayer
    {
        private Random r = new Random();

        public Placement NextMove(game gameState) {
            int i = r.Next(3);
            int j = r.Next(3);
            Placement p = new Placement(i, j);
            while (!gameState.isLegalMove(p)) {
                p.x = r.Next(3);
                p.y = r.Next(3);
            }
            return p;


        }
    }
}
