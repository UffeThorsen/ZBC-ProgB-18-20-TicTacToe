namespace TicTacToe
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //AITournament.RunLeague();
            //AITournament.RunNLeagues(10);
            //Running of the game! #FINALLY!
            Game game = ConsoleUI.SetupGame();
            ConsoleUI.RunGame(game);
        }
    }
}
