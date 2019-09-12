using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class JacobIAI : IPlayer
    {

        protected Placement RandomMove(Game gameState)
        {
            bool parsed = false;
            while (!parsed)
            {
                Random r = new Random();
                int i = r.Next(3);
                int j = r.Next(3);
                if (parsed)
                {
                    Placement move = new Placement(i, j);
                    if (gameState.IsLegalMove(move))
                    {
                        return move;
                    }
                }
            }
            return new Placement();
        }


        public Placement NextMove(Game gameState)
        {
            return RandomMove(gameState);
        }
    }
}
