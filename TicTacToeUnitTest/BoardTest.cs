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
        public void TestDefaultBoardConstructorWith3By3Board()
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

        // Testing the methode NInARow vertical
        [TestMethod]
        public void TestNInARowVertical()
        {
            Board b = new Board();
            b.Place(0, 0, Symbol.O);
            b.Place(1, 0, Symbol.O);
            b.Place(2, 0, Symbol.O);
            Assert.IsTrue(b.NInARow(Symbol.O, 3));
        }
        
        // Testing the methode NInARow horizontal
        [TestMethod]
        public void TestNInARowHorizontal()
        {
            Board b = new Board();
            b.Place(0, 0, Symbol.O);
            b.Place(0, 1, Symbol.O);
            b.Place(0, 2, Symbol.O);
            Assert.IsTrue(b.NInARow(Symbol.O, 3));
        }

        // Testing the methode NInARow given not 3 in a row
        [TestMethod]
        public void TestNInARowFalseExcpeted()
        {
            Board b = new Board();
            b.Place(0, 0, Symbol.O);
            b.Place(2, 0, Symbol.O);
            b.Place(2, 2, Symbol.O);
            Assert.IsFalse(b.NInARow(Symbol.O, 3));
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

        [TestMethod]
        //Ensures that Boards symbols are the symbols it was meant to place
        public void BoardSymbolTest()
        {
            Board board = new Board();
            Symbol symbToBoard = Symbol.X;
            Symbol symbFromBoard;
            int boardTestVertical = 0;
            int boardTestHorizontal = 0;
            while (boardTestHorizontal < 3)
            {
                while (boardTestVertical < 3)
                {
                    board.Place(boardTestHorizontal, boardTestVertical, symbToBoard);
                    symbFromBoard = board[boardTestHorizontal, boardTestVertical];
                    Assert.AreEqual(symbToBoard, symbFromBoard);
                    boardTestVertical++;
                }
                boardTestVertical = 0;
                boardTestHorizontal++;
            }
        }

        [TestMethod]
        //Asserts if you can place on every tile of the board
        public void BoardPlaceTest()
        {
            Board board = new Board();
            int boardTestVertical = 0;
            int boardTestHorizontal = 0;
            int worksEveryLoopCounter = 0;
            Symbol symbol = Symbol.X;
            for (int i = 1; i < 3; i++)
            {
                while (boardTestHorizontal < 3)
                {
                    while (boardTestVertical < 3)
                    {
                        board.Place(boardTestHorizontal, boardTestVertical, symbol);
                        if (board[boardTestHorizontal, boardTestVertical] == Symbol.X)
                        {
                            worksEveryLoopCounter++;
                        }
                        boardTestVertical++;
                    }
                    boardTestVertical = 0;
                    boardTestHorizontal++;
                }
            }
            Assert.AreEqual(worksEveryLoopCounter, 9);
        }

        //Determines if the program throws an IndexOutOfRangeException if player places out of board
        [ExpectedException(typeof(IndexOutOfRangeException))]
        [TestMethod]
        public void BoardPlaceOutOfBoardTest()
        {
            Board board = new Board();
            board.Place(5, 5, Symbol.X);
        }

        [TestMethod]
        //Asserts if N will still be N even if you try to remove it
        public void BoardRemoveSymbolNTest()
        {
            Board board = new Board();
            board.RemoveSymbolFromPlace(1, 1);
            Assert.AreEqual(board[1, 1], Symbol.N);
        }

        [TestMethod]
        //Checks if the board is full if nothing is placed.
        public void BoardBoardFullIfEmptyTest()
        {
            Board board = new Board();
            Assert.IsFalse(board.BoardFull());
        }
        [TestMethod]
        //Determines if the board is full once a player has placed on all tiles
        public void BoardBoardFullTest()
        {
            Board board = new Board();
            int boardTestHorizontal = 0;
            int boardTestVertical = 0;
            for (int i = 1; i < 3; i++)
            {
                while (boardTestHorizontal < 3)
                {
                    while (boardTestVertical < 3)
                    {
                        board.Place(boardTestHorizontal, boardTestVertical, Symbol.X);
                        boardTestVertical++;
                    }
                    boardTestVertical = 0;
                    boardTestHorizontal++;
                }
                Assert.IsTrue(board.BoardFull());
            }
        }
    }
}
