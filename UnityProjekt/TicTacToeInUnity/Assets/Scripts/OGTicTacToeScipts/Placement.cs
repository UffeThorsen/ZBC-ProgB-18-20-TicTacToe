
namespace TicTacToe
{
    public struct Placement
    {
        public int X { set; get; }
        public int Y { set; get; }

        public Placement(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}
