﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //No code in main in repository!!
            Board b = new Board();
            string before = b.ToString();
            b.Place(1,1,Symbol.X);
            string after = b.ToString();

            bool test = before != after;

            
            Console.WriteLine(test);
            Console.ReadKey();
            //at least not yet!
        }
    }
}
