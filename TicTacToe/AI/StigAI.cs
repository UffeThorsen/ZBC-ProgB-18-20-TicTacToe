using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class StigAI : IPlayer
    {
        private Random r = new Random();

        private Placement RandomMove(Game gameState)
        {
            Placement p = new Placement();
            p.X = r.Next(3);
            p.Y = r.Next(3);
            while (!gameState.IsLegalMove(p))
            {
                p.X = r.Next(3);
                p.Y = r.Next(3);
            }

            return p;
        }

        private bool AlmostWon(Game gameState)
        {
            //return gameState.GameBoard.NInARow((Symbol)gameState.CurrentPlayer, 2);
            throw new NotImplementedException();
        }

        public Placement NextMove(Game gameState)
        {
            return RandomMove(gameState);
        }
    }
}
