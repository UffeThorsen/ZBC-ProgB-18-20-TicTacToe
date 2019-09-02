namespace TicTacToe
{
    public interface IBoard{
        bool NInARow(Symbol s, int l);
        bool Place(int hor, int ver, Symbol player);
        void RemoveSymbolFromPlace(int hor, int ver);
        bool BoardFull();
        string ToString();
        Symbol this[int i, int j] { get; }
    }
}
