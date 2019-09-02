
namespace TicTacToe
{
    class Board : IBoard
    {
        Symbol[,] places;

        //Calls the other constructor with 3 as hori and 3 as vert
        public Board() : this(3,3) { }
         
        //Makes a new board with hori as amount of columns, and vert as the amount of rows
        //Hori means horizontal, Vert means vertical.
        Board(int hori, int vert)
        {
            places = new Symbol[hori,vert];
            /*for(int i = 0; i < places.GetLength(0); i++)
            {
                for (int j = 0; j < places.GetLength(1); j++)
                {
                    places[i, j] = Symbol.N;
                }
            }*/
        }

        public Symbol this[int i, int j]
        {
            get
            {
                return places[i, j];
            }
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

        /// <summary>
        /// Checks if n positions in a row (direction determined by di and dj) all are symbol s.
        /// </summary>
        /// <param name="s">Symbol to look for.</param>
        /// <param name="n">Length of straight.</param>
        /// <param name="i">Starting row index.</param>
        /// <param name="j">Starting column index.</param>
        /// <param name="di">Change in row index for each step.</param>
        /// <param name="dj">Change in column index for each step.</param>
        private bool NInARow(Symbol s, int n, int i, int j, int di, int dj)
        {
            int extremeI = i + (n - 1) * di;
            int extremeJ = j + (n - 1) * dj;
            //i too large/small for n
            if(extremeI < 0 || extremeI >= places.GetLength(0))
            {
                return false;
            }
            //j too large/small for n
            if(extremeJ < 0 || extremeJ >= places.GetLength(1))
            {
                return false;
            }
            //not all symbol s
            for(int k=0; k<n; k++)
            {
                if(places[i + k*di, j + k*dj] != s)
                {
                    return false;
                }
            }
            //Passed all tests
            return true;
        }

        /// <summary>
        /// Checks if a straight of symbol exists.
        /// Horisontally, vertically or diagonally.
        /// </summary>
        /// <param name="symbol">Symbol to look for.</param>
        /// <param name="length">Length of straight.</param>
        public bool NInARow(Symbol symbol, int length)
        {
            for(int i=0; i<places.GetLength(0); i++)
            {
                for(int j=0; j<places.GetLength(1); j++)
                {
                    //horisontal +j
                    if (NInARow(symbol, length, i, j, 0, 1)) { return true; }
                    //vertical +i
                    if (NInARow(symbol, length, i, j, 1, 0)) { return true; }
                    //diagonal +i +j
                    if (NInARow(symbol, length, i, j, 1, 1)) { return true; }
                    //diagonal -i +j
                    if (NInARow(symbol, length, i, j, -1, 1)) { return true; }
                }
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

        //Returns a string with a new line for each row, and a tab between each column, with the symbol name as the string text for the value of the symbol
        public override string ToString()
        {
            string tempString = "";
            for (int i = 0; i < places.GetLength(0); i++)
            {
                for (int j = 0; j < places.GetLength(1); j++)
                {
                    tempString += places[i, j] + "\t";
                }
                tempString += "\n";
            }
            return tempString;
        }

        public bool BoardFull()
        {
            return !this.ToString().Contains("N");
        }

    }
}
