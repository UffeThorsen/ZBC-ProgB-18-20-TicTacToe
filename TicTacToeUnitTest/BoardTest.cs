using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToeUnitTest
{
    [TestClass]
    public class BoardTest
    {
        // Test if you can make a (default) board
        [TestMethod]
        public void TestBoardConstructor()
        {
            Board b = new Board();
        }

        // Test if you can place a symbol
        [TestMethod]
        public void TestPlaceSymbol()
        {
            Board b = new Board();
            string before = b.ToString();
            b.Place(0, 0, Symbol.X);
            string after = b.ToString();

            Assert.AreNotSame(after, before);
        }

        // Test if you can remove a symbol
        [TestMethod]
        public void TestRemoveSymbol()
        {
            Board b = new Board();
            b.Place(0, 0, Symbol.X);
            string before = b.ToString();
            b.RemoveSymbolFromPlace(0, 0);
            string after = b.ToString();

            Assert.AreNotSame(after, before);
        }

        // Test if you can place a symbol on another symbol
        [TestMethod]
        public void TestSymbolOnSymbol()
        {
            Board b = new Board();
            b.Place(0, 0, Symbol.X);
            string before = b.ToString();
            b.Place(0, 0, Symbol.O);
            string after = b.ToString();

            Assert.AreEqual(after, before);
        }

    }
}
