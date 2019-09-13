namespace TicTacToe
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Running of the game! #FINALLY!
            Game game = ConsoleUI.SetupGame();
            ConsoleUI.RunGame(game);
        }
    }
}
