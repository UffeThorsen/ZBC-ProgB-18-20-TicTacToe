
namespace TicTacToe
{
    class Board
    {

        public enum Symbol
        {
            N,
            O,
            X
        }

        Symbol[,] places;

        Board()
        {
            places = Symbol[3, 3]();
        }

        Board(int hori, int vert)
        {
            places = Symbol[hori,vert]();
        }

        public bool ThreeInARow(int player)
        {
            return NInARow(player, 3);
        }

        public bool NInARow(int player, int length)
        {
            
        }

        /// <summary>
        /// Place a symbol at a place. Hor is the position for the horizontal (starts at 0), the same goes for ver. The player is an int either 1 or 2.
        /// </summary>
        /// <param name="hor"></param>
        /// <param name="ver"></param>
        /// <param name="player"></param>
        /// <returns>A Bool that if placing was succesful = true</returns>
        public bool Place(int hor,int ver, int player)
        {
            if (places[hor, ver] != Symbol.N)
            {
                if (player == 1)
                {
                    places[hor, ver] = Symbol.O;
                }
                else{
                    places[hor, ver] = Symbol.X;
                }
                return true;
            }
            return false;
        }

        public override string ToString()
        {

        }

    }
}
