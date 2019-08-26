using System;

namespace TicTacToe
{
    class Board
    {
        Symbol[,] places;

        public Board() : this(3,3) { }

        Board(int hori, int vert)
        {
            places = new Symbol[hori,vert];
        }

        /// <summary>
        /// Checks for 3 of the same symbols in a row
        /// </summary>
        /// <param name="player"></param>
        /// <returns>bool true if 3 are in a row</returns>
        public bool ThreeInARow(int player)
        {
            return NInARow(player, 3);
        }

        public bool NInARow(int player, int length)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Place a symbol at a place. Hor is the position for the horizontal (starts at 0), the same goes for ver. The player is a Symbol.
        /// </summary>
        /// <param name="hor"></param>
        /// <param name="ver"></param>
        /// <param name="player"></param>
        /// <returns>A Bool that if placing was succesful = true</returns>
        public bool Place(int hor,int ver, Symbol player)
        {
            if (places[hor, ver] != Symbol.N)
            {
                places[hor, ver] = player;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Removes the symbol in the given place.
        /// </summary>
        /// <param name="hor"></param>
        /// <param name="ver"></param>
        public void RemoveSymbolFromPlace(int hor, int ver)
        {
            places[hor, ver] = Symbol.N;
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

    }
}
