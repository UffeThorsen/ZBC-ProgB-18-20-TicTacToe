using System;
namespace TicTacToe
{
    class Game
    {
        int currentPlayer = 1;
        int winningPlayer = 0;
        Board gameBoard = new Board();
        public Symbol CurrentPlayer {
            get
            {
                return (Symbol)currentPlayer;
            }
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
        /// <summary>
        /// Same as other turn but for moving
        /// </summary>
        /// <param name="behor"></param>
        /// <param name="bever"></param>
        /// <param name="hor"></param>
        /// <param name="ver"></param>
        /// <returns> If the turn was successful </returns>
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
        /// <summary>
        /// Moves a spot from (behor,bever) to (hor,ver)
        /// </summary>
        /// <param name="behor"></param>
        /// <param name="bever"></param>
        /// <param name="hor"></param>
        /// <param name="ver"></param>
        /// <returns> If it was able to be placed </returns>
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

        /// <summary>
        /// Will return the Winning player, if noone has won i returns a blank symbol
        /// </summary>
        /// <returns> The player who has won </returns>
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
