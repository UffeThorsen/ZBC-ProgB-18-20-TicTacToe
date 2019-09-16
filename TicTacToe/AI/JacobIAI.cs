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
                Placement move = new Placement(i, j);
                if (gameState.IsLegalMove(move))
                {
                    return move;
                }
            }
            return new Placement();
        }

        protected Placement DefaltMove(Game gameState)
        {
            Placement[] stradOne =
            {
                new Placement(2,0),
                new Placement(0,2),
                new Placement(2,2),
                new Placement(2,1),
                new Placement(1,2)
            };

            Placement[] stradTwo =
            {
                new Placement(2,1),
                new Placement(1,2),
                new Placement(2,2),
                new Placement(2,0),
                new Placement(0,2)
            };

            Random r = new Random();
            int j = r.Next(2);

            bool parsed = false;
            while (!parsed)
            {
                if (j == 1)
                {
                    int i = 0;
                    Placement move = stradOne[i];
                    if (gameState.IsLegalMove(move))
                    {
                        return move;
                    }
                    else if (i == stradOne.Length)
                    {
                        parsed = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                {
                    int i = 0;
                    Placement move = stradTwo[i];
                    if (gameState.IsLegalMove(move))
                    {
                        return move;
                    }
                    else if (i == stradTwo.Length)
                    {
                        parsed = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                return RandomMove(gameState);
            }
            return RandomMove(gameState);

        }

        public Placement NextMove(Game gameState)
        {
            return DefaltMove(gameState);
        }
    }
}
