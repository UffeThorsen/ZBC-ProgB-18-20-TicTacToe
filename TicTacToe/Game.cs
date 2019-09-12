using System.Collections.Generic;
namespace TicTacToe
{
    class Game
    {
        List<IPlayer> players;
        int currentPlayerIndex = 0;
        int winningPlayer = -1;
        Board gameBoard = new Board();

        public bool IsGameDone {
            get
            {
                return gameBoard.BoardFull() || HasPlayerWon(currentPlayerIndex);
            }
        }

        private Game() {}

        public Game(List<IPlayer> players)
        {
            this.players = players;
        }

        public Symbol CurrentPlayer {
            get
            {
                return (Symbol)(currentPlayerIndex + 1);
            }
        }


        public bool IsLegalMove(Placement p)
        {
            if(gameBoard[p.X, p.Y] == Symbol.N)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void NextMove()
        {
            Placement p = players[currentPlayerIndex].NextMove(this);
            gameBoard.Place(p.X, p.Y, (Symbol)currentPlayerIndex + 1);
            if (HasPlayerWon(currentPlayerIndex))
            {
                winningPlayer = currentPlayerIndex + 1;
            }
            ChangeTurn();
        }
        
        /// <summary>
        /// Cycles trough the players in order.
        /// </summary>
        void ChangeTurn()
        {
            currentPlayerIndex = (currentPlayerIndex + 1) % players.Count;
        }

        /// <summary>
        /// Checks if someone has won
        /// </summary>
        /// <param name="player"> The player to check </param>
        /// <returns></returns>
        bool HasPlayerWon(int player)
        {
            if (gameBoard.ThreeInARow((Symbol)currentPlayerIndex + 1))
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
