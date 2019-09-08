using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace TicTacToe
{
    
    class DanielsConsoleUI
    {

        static int position = 2;

        static public void PrintUI(Game game)
        {
            
            while (true)
            {
                string[] temp = game.ToString().Split(' ');
                temp[position] = "■";
                WriteLine(ArrToSingleString(temp));
                Thread.Sleep(50);
                Clear();
                WriteLine(game.ToString());
                Thread.Sleep(100);
            }
        }

        static string ArrToSingleString(string[] s)
        {
            string temp = "";
            for (int i = 1; i <= s.Length; i++)
            {

                temp += s[i-1] + " ";

                if (i % 3 == 0)
                {
                    temp += "\n";
                }
            }
            return temp;
        }

    }


}
