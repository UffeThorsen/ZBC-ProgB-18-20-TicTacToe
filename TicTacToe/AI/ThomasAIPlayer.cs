using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class ThomasAIPlayer : IPlayer
    {
        private Random r = new Random();

        public Placement NextMove(Game gameState)
        {
            if (TwoInARow(gameState, 1, 0, 2, 0) && gameState[0, 0] == Symbol.N || TwoInARow(gameState, 0, 1, 0, 2) && gameState[0, 0] == Symbol.N || TwoInARow(gameState, 1, 1, 2, 2) && gameState[0, 0] == Symbol.N)
            {
                return new Placement(0, 0);
            }
            else if (TwoInARow(gameState, 1, 1, 1, 2) && gameState[0, 1] == Symbol.N)
            {
                return new Placement(0, 1);
            }
            else if (TwoInARow(gameState, 0, 0, 1, 0) && gameState[2, 0] == Symbol.N || TwoInARow(gameState, 2, 1, 2, 2) && gameState[2, 0] == Symbol.N || TwoInARow(gameState, 0, 2, 1, 1) && gameState[2, 0] == Symbol.N)
            {
                return new Placement(2, 0);
            }
            else if (TwoInARow(gameState, 1, 1, 1, 2) && gameState[1, 0] == Symbol.N)
            {
                return new Placement(1, 0);
            }
            else if (TwoInARow(gameState, 0, 1, 1, 1) && gameState[2, 1] == Symbol.N)
            {
                return new Placement(2, 1);
            }
            else if (TwoInARow(gameState, 1, 2, 2, 2) && gameState[0, 2] == Symbol.N || TwoInARow(gameState, 0, 0, 0, 1) && gameState[0, 2] == Symbol.N || TwoInARow(gameState, 1, 1, 2, 0) && gameState[0, 2] == Symbol.N)
            {
                return new Placement(0, 2);
            }
            else if (TwoInARow(gameState, 1, 0, 1, 1) && gameState[1, 2] == Symbol.N)
            {
                return new Placement(1, 2);
            }
            else if (TwoInARow(gameState, 0, 2, 1, 2) && gameState[2, 2] == Symbol.N || TwoInARow(gameState, 0, 0, 1, 1) && gameState[2, 2] == Symbol.N || TwoInARow(gameState, 2, 0, 2, 1) && gameState[2, 2] == Symbol.N)
            {
                return new Placement(2, 2);
            }
            else
            {
                RandomMove(gameState);
            }
            return new Placement();//for compiler only
        }

        private bool TwoInARow(Game gameState, int x1, int y1, int x2, int y2)
        {
            if(gameState[x1, y1] == Symbol.X && gameState[x2, y2] == Symbol.X || gameState[x1, y1] == Symbol.O && gameState[x2, y2] == Symbol.O)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Placement RandomMove(Game gameState)
        {
            int i = r.Next(3);
            int j = r.Next(3);
            Placement p = new Placement(i, j);

            while (!gameState.IsLegalMove(p))
            {
                p.X = r.Next(3);
                p.Y = r.Next(3);
            }
            return p;
        }
    }
}
