using System;
namespace TicTacToe
{
    class Game
    {
        int currentPlayer = 1;
        int winningPlayer = 0;
        Board gameBoard = new Board();

        public Game()
        {

        }

        /// <summary>
        /// Executes a turn returns if the spot was taken or not
        /// </summary>
        /// <param name="hor"> Where to place on the horizontal axis </param>
        /// <param name="ver"> Where to place on the vertical axis </param>
        public bool Turn(int hor, int ver)
        {
            
            if(gameBoard.Place(hor, ver, (Symbol)currentPlayer))
            {
                if (HasPlayerWon(currentPlayer))
                {
                    winningPlayer = currentPlayer;
                }
                ChangeTurn();
                return true;
            }
            return false;
        }
        public bool Turn(int behor, int bever, int hor, int ver)
        {
            
            if (Move(behor, bever, hor, ver))
            {
                if (HasPlayerWon(currentPlayer))
                {
                    winningPlayer = currentPlayer;
                }
                ChangeTurn();
                return true;
            }
            return false;
        }

        bool Move(int behor, int bever, int hor, int ver)
        {
            gameBoard.RemoveSymbolFromPlace(behor, bever);
            if (!gameBoard.Place(hor, ver, (Symbol)currentPlayer))
            {
                gameBoard.Place(bever, behor, (Symbol)currentPlayer);
                return false;
            }
            else
            {
                return true;
            }   
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
            return (Symbol)winningPlayer;
        }
        
        public override string ToString()
        {
            return gameBoard.ToString();
        }


    }
}
