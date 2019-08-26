using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class BoardTest
    {

        public bool TestBoardPlace()
        {
            Board b = new Board();
            string before = b.ToString();
            b.Place(1, 1, Symbol.X);
            string after = b.ToString();

            bool test = before != after;

            Console.WriteLine(test);
            return test;
        }


        public void Test()
        {

        }

        public void Testing()
        {
            Console.WriteLine("Press any button to exit...");
            Console.ReadKey();
        }
    }
}

