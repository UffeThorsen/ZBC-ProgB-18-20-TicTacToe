using System.Collections.Generic;
namespace TicTacToe
{
    class Game
    {
        List<IPlayer> players;
        IPlayer currentPlay;
        int currentPlayer = 1;
        int winningPlayer = 0;
        Board gameBoard = new Board();

        public bool IsGameDone {
            get
            {
                return gameBoard.BoardFull();
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
                return (Symbol)currentPlayer;
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
            Placement p = players[currentPlayer - 1].NextMove(this);
            gameBoard.Place(p.X, p.Y, (Symbol)currentPlayer);
            if (HasPlayerWon(currentPlayer))
            {
                winningPlayer = currentPlayer;
            }
            ChangeTurn();
        }
        
        void ChangeTurn()
        {
            if(currentPlayer <= players.Count)
            {
                currentPlayer++;
            }
            else
            {
                currentPlayer = 1;
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
