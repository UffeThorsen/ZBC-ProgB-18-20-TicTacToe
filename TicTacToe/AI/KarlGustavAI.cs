using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class KarlGustavAI : IPlayer
    {
        public Placement NextMove(Game gameState)
        {
            int x;
            int y;
            Placement place = new Placement (0, 0);
            while (!gameState.IsLegalMove(place))
            {
                for (int i = 0; i > 3; i++)
                {
                    Placement p = new Placement(x, y);
                    if (gameState.IsLegalMove(p))
                    {
                        return p;
                    }
                    y++;

                }
                y = 0;
                x++;
            }
            return place;
        }
    }
}
