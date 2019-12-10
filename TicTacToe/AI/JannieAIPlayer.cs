using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class JannieAIPlayer : IPlayer
    {

        //Find random number and placements 

        public Placement NextMove(Game gameState)
        {
            throw new NotImplementedException();
            /*Placement p = new Placement(i, j);
            while (!gameState.IsLegalMove(p))
            {
                for(int i = 0; i< 3; i++)
                {
                    for(int j = 0; j < 3; i++)
                    {
                        p(i, j);
                    }
                }
            }
            return p;
                //while-loop indtil gameState.IsLegalMove(p)
                //for-loop checks every row in the board for a placement
                //for-loop checks every column in the row
                //placement p = new Placement(i,j);
            */
        }
    }
}
