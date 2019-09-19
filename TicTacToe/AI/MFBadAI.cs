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

        public Placement NextMove(Game gameState) {
            int i = r.Next(3);
            int j = r.Next(3);
            Placement p = new Placement(i, j);
            while (!gameState.IsLegalMove(p)) {
                p.X = r.Next(3);
                p.Y = r.Next(3);
            }
            return p;


        }
    }
}
