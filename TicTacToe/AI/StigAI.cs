using System;
using System.Collections.Generic;

namespace TicTacToe
{
    class StigAI : IPlayer
    {
        private Random r = new Random();
        private Placement[] allwaysTryMoves = {
            new Placement(1, 1),
            new Placement(2, 2),
            new Placement(0, 0),
            new Placement(0, 2),
            new Placement(2, 0) 
            };

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
            return BestMove(gameState);
        }

        private Placement BestMove(Game gameState)
        {
            foreach (Placement p in allwaysTryMoves)
            {
                if (gameState.IsLegalMove(p))
                {
                    return p;
                }
            }
            return RandomMove(gameState);
        }
    }
}
