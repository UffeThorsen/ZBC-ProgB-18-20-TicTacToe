using System.Collections.Generic;
using System;

namespace TicTacToe
{
    public class Game
    {
        private static readonly Symbol[] playerIndexToSymbol = { Symbol.X, Symbol.O };

        List<IPlayer> players;
        int currentPlayerIndex = 0;
        int? winningPlayer = null;
        Board gameBoard = new Board();

        /// <summary>
        /// Returns the symbol at position (i, j).
        /// </summary>
        public Symbol this[int i, int j] {
            get {
                return gameBoard[i, j];
            }
        }
        /// <summary>
        /// Returns the symbol at position p.
        /// </summary>
        public Symbol this[Placement p] {
            get {
                return gameBoard[p.X, p.Y];
            }
        }

        /// <summary>
        /// Contains information describing whether game is over.
        /// </summary>
        public bool IsGameDone {
            get
            {
                return gameBoard.BoardFull() || winningPlayer!=null;
            }
        }

        /// <summary>
        /// Contains the symbol of the current player.
        /// </summary>
        public Symbol CurrentPlayer {
            get {
                return playerIndexToSymbol[currentPlayerIndex];
            }
        }

        private Game() {}

        public Game(IPlayer p1, IPlayer p2)
        {
            if(p1 == null || p2 == null)
            {
                throw new ArgumentException("Players must be non-null.");
            }
            if(ReferenceEquals(p1, p2))
            {
                throw new ArgumentException("Players must be distinct.");
            }
            this.players = new List<IPlayer> { p1, p2 };
        }

        /// <summary>
        /// Returns true iff p is not occupied by a player symbol.
        /// </summary>
        public bool IsLegalMove(Placement p)
        {
            return gameBoard[p.X, p.Y] == Symbol.N;
        }

        /// <summary>
        /// Makes the current player decide on next move and performs the move.
        /// Then changes current player to the next player.
        /// </summary>
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
        
        /// <summary>
        /// Returns string description of current game state.
        /// </summary>
        public override string ToString()
        {
            return gameBoard.ToString();
        }
    }
}
