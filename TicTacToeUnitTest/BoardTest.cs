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

        // Testing if the constructor work
        [TestMethod]
        public void TestIfBoardConstructorWorkAsExpected()
        {
            Board b = new Board();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.IsTrue(b[i, j] == Symbol.N);
                }
            }
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

        // Testing the methode NInARow
        [TestMethod]
        public void TestNInARow()
        {
            Board b = new Board();
            b.Place(0, 0, Symbol.O);
            b.Place(1, 0, Symbol.O);
            b.Place(2, 0, Symbol.O);
            Assert.IsTrue(b.NInARow(Symbol.O, 3));
        }

        // Testing if Three in a Row works with DiagonalLeft
        [TestMethod]
        public void TestThreeInARowDiagonalLeft()
        {
            Board bDiagonalLeft = new Board();
            bDiagonalLeft.Place(0, 2, Symbol.X);
            bDiagonalLeft.Place(1, 1, Symbol.X);
            bDiagonalLeft.Place(2, 0, Symbol.X);
            Assert.IsTrue(bDiagonalLeft.ThreeInARow(Symbol.X));
        }

        // Testing if Three in a Row works with DiagonalRight      
        [TestMethod]
        public void TestThreeInARowDiagonalRight()
        {
            Board bDiagonalRight = new Board();
            bDiagonalRight.Place(0, 0, Symbol.X);
            bDiagonalRight.Place(1, 1, Symbol.X);
            bDiagonalRight.Place(2, 2, Symbol.X);
            Assert.IsTrue(bDiagonalRight.ThreeInARow(Symbol.X));
        }
    }
}
