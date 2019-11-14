using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToeUnitTest
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void TestBoardConstructor()
        {
            Board b = new Board();
        }
    }
}
