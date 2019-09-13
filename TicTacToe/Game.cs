using System.Collections.Generic;
namespace TicTacToe
{
    class Game
    {
        private static readonly Symbol[] playerIndexToSymbol = { Symbol.X, Symbol.O };

        List<IPlayer> players;
        int currentPlayerIndex = 0;
        int? winningPlayer = null;
        Board gameBoard = new Board();

        public Symbol this[int i, int j] {
            get {
                return gameBoard[i, j];
            }
        }
        public Symbol this[Placement p] {
            get {
                return gameBoard[p.X, p.Y];
            }
        }

        public bool IsGameDone {
            get
            {
                return gameBoard.BoardFull() || winningPlayer!=null;
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
                return playerIndexToSymbol[currentPlayerIndex];
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
            Placement p = players[currentPlayerIndex].NextMove(this);//TODO: "this" should be a copy
            gameBoard.Place(p.X, p.Y, playerIndexToSymbol[currentPlayerIndex]);
            if (HasPlayerWon(currentPlayerIndex))
            {
                winningPlayer = currentPlayerIndex;
            }
            ChangeTurn();
        }
        
        /// <summary>
        /// Cycles trough the players in order.
        /// </summary>
        private void ChangeTurn()
        {
            currentPlayerIndex = (currentPlayerIndex + 1) % players.Count;
        }

        /// <summary>
        /// Checks if someone has won
        /// </summary>
        /// <param name="playerIndex"> The player to check </param>
        /// <returns></returns>
        bool HasPlayerWon(int playerIndex)
        {
            return gameBoard.ThreeInARow(playerIndexToSymbol[playerIndex]);
        }

        /// <summary>
        /// Will return the Winning player, if noone has won i returns a blank symbol
        /// </summary>
        /// <returns> The player who has won </returns>
        public IPlayer WhoWon()
        {
            if(winningPlayer == null)
            {
                return null;
            }
            else
            {
                return players[(int)winningPlayer];
            }
        }
        
        public override string ToString()
        {
            return gameBoard.ToString();
        }
    }
}
