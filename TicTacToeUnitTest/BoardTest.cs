﻿using System;
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

        /// <summary>
        /// Testing if the constructor work
        /// </summary>
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

        /// <summary>
        /// Testing the methode NInARow
        /// </summary>
        [TestMethod]
        public void TestNInARow()
        {
            Board b = new Board();
            b.Place(0, 0, Symbol.O);
            b.Place(1, 0, Symbol.O);
            b.Place(2, 0, Symbol.O);
            Assert.IsTrue(b.NInARow(Symbol.O, 3));
        }

        /// <summary>
        /// Testing if Three in a Row works with DiagonalLeft
        /// </summary>
        [TestMethod]
        public void TestThreeInARowDiagonalLeft()
        {
            Board bDiagonalLeft = new Board();
            bDiagonalLeft.Place(0, 2, Symbol.X);
            bDiagonalLeft.Place(1, 1, Symbol.X);
            bDiagonalLeft.Place(2, 0, Symbol.X);
            Assert.IsTrue(bDiagonalLeft.ThreeInARow(Symbol.X));
        }

        /// <summary>
        /// Testing if Three in a Row works with DiagonalRight      
        /// </summary>
        [TestMethod]
        public void TestThreeInARowDiagonalRight()
        {
            Board bDiagonalRight = new Board();
            bDiagonalRight.Place(0, 0, Symbol.X);
            bDiagonalRight.Place(1, 1, Symbol.X);
            bDiagonalRight.Place(2, 2, Symbol.X);
            Assert.IsTrue(bDiagonalRight.ThreeInARow(Symbol.X));
        }

        /// <summary>
        /// Testing for 4 in a row with NinARow, the test will fail for now but should work in the future with a bigger board then 3*3
        /// </summary>
        [TestMethod]
        public void Test4InARow()
        {
            Board b = new Board();
            b.Place(0, 0, Symbol.X);
            b.Place(1, 0, Symbol.X);
            b.Place(2, 0, Symbol.X);
            b.Place(3, 0, Symbol.X);
            Assert.IsTrue(b.NInARow(Symbol.X, 4));
        }
    }
}
