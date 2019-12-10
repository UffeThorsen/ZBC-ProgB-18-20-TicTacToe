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

    public class DanielsEpicAI : IPlayer
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
            UffeSmarterAIPlayer uffeSmarterAI = new UffeSmarterAIPlayer();
            return uffeSmarterAI.NextMove(gameState);
        }
   }

}
