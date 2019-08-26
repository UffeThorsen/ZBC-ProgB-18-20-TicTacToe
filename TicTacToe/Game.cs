using System;
namespace TicTacToe
{
    class Game
    {
        int currentPlayer = 1;

        bool hasXWon = false;
        bool hasOWon = false;

        Board gameBoard = new Board();

        public Game()
        {

        }

        /// <summary>
        /// Udfører en tur (En tur består af at placere en brik, tjekke om spilleren har vundet og skifte spiller)
        /// </summary>
        /// <param name="hor"> Where to place on the horizontal axis </param>
        /// <param name="ver"> Where to place on the vertical axis </param>
        public bool Turn(int hor, int ver)
        {
            gameBoard.Place(hor,ver, (Symbol)currentPlayer);
            
            if (HasPlayerWon(currentPlayer))
            {
                return true;
            }
            ChangeTurn();
            return false;
        }

        /// <summary>
        /// Changes the turn of the current player
        /// </summary>
        void ChangeTurn()
        {
            if (currentPlayer == 1)
            {
                currentPlayer++;
            }
            else if (currentPlayer == 2)
            {
                currentPlayer--;
            }
        }
        bool HasPlayerWon(int player)
        {
            if (gameBoard.ThreeInARow((Symbol)currentPlayer))
            {
                return true;
            }
            return false;
        }

        public Symbol WhoWon()
        {
            if(hasOWon)
            {
                return Symbol.O;
            }
            else if(hasXWon)
            {
                return Symbol.X;
            }
            else
            {
                return Symbol.N;
            }
        }
        
    }
}
