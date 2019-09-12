using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{

    class NoAvailableMoveException : ApplicationException
    {
        public NoAvailableMoveException()
        {

        }
    }

    class DanielsEpicAI : IPlayer
    {

        protected Placement FirstAvaiableMovement(Game gameState)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (gameState.IsLegalMove(new Placement(i, j)))
                    {
                        return new Placement(i, j);
                    }
                }

            }
            throw new NoAvailableMoveException();
        }

        public Placement NextMove(Game gameState)
        {
            return FirstAvaiableMovement(gameState);
        }
    }

    class DanielsEpicerAI : DanielsEpicAI
    {
        public Placement NextMove(Game gameState)
        {
            if(gameState.IsLegalMove(new Placement(0,2)))
            {
                return new Placement(0, 2);
            }
            else if (gameState.IsLegalMove(new Placement(2, 0)))
            {
                return new Placement(2, 0);
            }
            return FirstAvaiableMovement(gameState);
        }
   }

}
