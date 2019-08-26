using System;

namespace TicTacToe
{
    class Board
    {
        Symbol[,] places;

        //Calls the other constructor with 3 as hori and 3 as vert
        public Board() : this(3,3) { }

        //Makes a new board with hori as amount of columns, and vert as the amount of rows
        Board(int hori, int vert)
        {
            places = new Symbol[hori,vert];
        }

        /// <summary>
        /// Checks for 3 of the same symbols in a row
        /// </summary>
        /// <param name="player"></param>
        /// <returns>bool true if 3 are in a row</returns>
        public bool ThreeInARow(Symbol player)
        {
            return NInARow(player, 3);
        }

        public bool NInARow(Symbol player, int length)
        {
            throw new System.NotImplementedException();

            // Goes throug the symobol 2darry, and cheks if the symbol of the place is the same at the player chekking for.
            int inARow = 0;
            for (int i = 0; i < places.length; i++)
            {
                for(int j = 0; j < places.length; j++)
                {
                    if (places[i, j] == player)
                    {
                        inARow++;
                        if (inARow == length)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                inARow = 0;
            }

            return false;
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
            if (places[hor, ver] == Symbol.N)
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

        //Returns a string with a new line for each row, and a tab between each column, with the symbol name as the string text for the value
        public override string ToString()
        {
            string tempString = "";
            for (int i = 0; i < places.GetLength(0); i++)
            {
                for (int j = 0; j < places.GetLength(1); j++)
                {
                    tempString = places[i, j] + "\t";
                }
                tempString = "\n";
            }
        }

    }
}
