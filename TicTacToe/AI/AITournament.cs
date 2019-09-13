using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class AITournament
    {
        public static void RunLeague()
        {
            RunLeague(3, 0, 1);
        }

        public static void RunLeague(int win, int loss, int tie)
        {
            Type[] AIs = ConsoleUI.NoMove3by3AIs;
            int[] scores = new int[AIs.Length];
            for(int i=0; i<AIs.Length; i++)
            {
                for(int j=0; j<AIs.Length; j++)
                {
                    if (i != j && i != 0 && j != 0) {
                        Console.WriteLine("Now playing: " + AIs[i] + " vs. " + AIs[j]);
                        var players = new List<IPlayer>();
                        players.Add( (IPlayer)Activator.CreateInstance(AIs[i]) );
                        players.Add( (IPlayer)Activator.CreateInstance(AIs[j]) );
                        Game game = new Game(players);
                        while (!game.IsGameDone)
                        {
                            game.NextMove();
                        }
                        //if first player won, add win to scores[i] and loss to scores[j]
                        //if second player won, add win to scores[j] and loss to scores[i]
                        //if tied, add tie to scores[i] and scores[j]
                    }
                }
            }

            Console.WriteLine("The final scores are: \n");
            for(int i=0; i<AIs.Length; i++)
            {
                Console.WriteLine(scores[i] + "\t-\t" + AIs[i]);
            }
        }
    }
}
