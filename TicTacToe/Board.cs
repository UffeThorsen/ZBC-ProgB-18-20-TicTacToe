
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

        public bool Place(int hor,int ver, int player)
        {
           
        }

        public override string ToString()
        {

        }

    }
}
