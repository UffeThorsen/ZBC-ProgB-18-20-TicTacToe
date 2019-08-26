using System;
namespace TicTacToe
{
    class Game
    {
        int currentPlayer = 1;

        Board gameBoard = new Board();

        public Game()
        {

        }

        /// <summary>
        /// Executes a turn returns if someone has won
        /// </summary>
        /// <param name="hor"> Where to place on the horizontal axis </param>
        /// <param name="ver"> Where to place on the vertical axis </param>
        public bool Turn(int hor, int ver)
        {
            gameBoard.Place(hor, ver, (Symbol)currentPlayer);
            if (HasPlayerWon(currentPlayer))
            {
                return true;
            }
            ChangeTurn();
            return false;
        }
        public bool Turn(int behor, int bever, int hor, int ver)
        {
            Move(behor,bever,hor,ver);
            if (HasPlayerWon(currentPlayer))
            {
                return true;
            }
            ChangeTurn();
            return false;
        }

        void Move(int behor, int bever, int hor, int ver)
        {
            gameBoard.RemoveSymbolFromPlace(behor,bever);
            gameBoard.Place(hor,ver,(Symbol)currentPlayer);
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

        /// <summary>
        /// Checks if someone has won
        /// </summary>
        /// <param name="player"> The player to check </param>
        /// <returns></returns>
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
            return (Symbol)currentPlayer;
        }
        
    }
}
