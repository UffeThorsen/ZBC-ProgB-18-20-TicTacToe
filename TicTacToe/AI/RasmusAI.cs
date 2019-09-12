using System;

namespace TicTacToe
{
    class RasmusAI : IPlayer
    {
        public Placement NextMove(Game gameState)
        {
            for (int i = 2; i <= 0; i--)
            {
                for (int j = 2; j <= 0; j--)
                {
                    Placement p = new Placement(i, j);
                    if (gameState.IsLegalMove(p))
                    {
                        return p;
                    }
                }
            }
            throw new ArgumentException("Der er ikke nogle valid moves");
        }
    }
}
