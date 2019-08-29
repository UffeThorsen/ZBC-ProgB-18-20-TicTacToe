using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class BoardTest
    {
        // Test if you can place a symbol
        public bool TestBoardPlace()
        {
            Board b = new Board();
            string before = b.ToString();
            b.Place(0, 0, Symbol.X);
            string after = b.ToString();

            bool test = before != after;

            Console.WriteLine(test);
            return test;
        }

        // Test if you can remove a symbol
        public bool TestBoardRemove()
        {
            Board b = new Board();
            b.Place(0, 0, Symbol.X);
            string before = b.ToString();
            b.RemoveSymbolFromPlace(0,0);
            string after = b.ToString();

            bool test = before != after;

            Console.WriteLine(test);
            return test;
        }

        // Test if you can place a symbol on another symbol
        public bool TestBoardPlaceObjectOnObject()
        {
            Board b = new Board();
            b.Place(0, 0, Symbol.X);
            string before = b.ToString();
            Console.WriteLine(b);
            b.Place(0, 0, Symbol.O);
            string after = b.ToString();
            Console.WriteLine(b);

            bool test = before == after;

            Console.WriteLine(test);
            return test;
        }

        public void GameTest()
        {

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

