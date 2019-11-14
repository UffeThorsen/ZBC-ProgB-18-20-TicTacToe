using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToeUnitTest
{
    public class TestAI : IPlayer
    {
        public virtual Placement NextMove(Game gameState)
        {
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Placement p = new Placement(i, j);
                    if (gameState.IsLegalMove(p))
                    {
                        return p;
                    }
                }
            }
            return new Placement();
        }
    }

    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void TestGameConstructor()
        {
            IPlayer p1 = new UffeAIPlayer();
            IPlayer p2 = new UffeAIPlayer();
            Game g = new Game(p1, p2);
        }

        [ExpectedException(typeof(ArgumentException), AllowDerivedTypes = true)]
        [TestMethod]
        public void TestGameConstructorWithNullPlayer()
        {
            IPlayer p1 = null;
            IPlayer p2 = null;
            Game g = new Game(p1, p2);
        }

        [ExpectedException(typeof(ArgumentException), AllowDerivedTypes = true)]
        [TestMethod]
        public void TestGameConstructorWithSamePlayerTwice()
        {
            IPlayer p1 = new TestAI();
            Game g = new Game(p1, p1);
        }

        /// <summary>
        /// Testing if game is able to change player correctly
        /// </summary>
        [TestMethod]
        public void TestChangePlayer()
        {
            IPlayer p1 = new TestAI();
            IPlayer p2 = new TestAI();
            Game g = new Game(p1,p2);
            Symbol startPlayer = g.CurrentPlayer;
            g.NextMove();
            Assert.AreNotEqual(startPlayer, g.CurrentPlayer);
        }

        /// <summary>
        /// Testing if the board state is being changed after doing a move
        /// </summary>
        [TestMethod]
        public void TestBoardStateInGame()
        {
            IPlayer p1 = new TestAI();
            IPlayer p2 = new TestAI();
            Game g = new Game(p1, p2);
            string state = g.ToString();
            g.NextMove();
            Assert.AreNotEqual(state, g.ToString());
        }

        /// <summary>
        /// Testing if anyone won on a blank board
        /// </summary>
        [TestMethod]
        public void TestWhoWonBlankBoard()
        {
            IPlayer p1 = new TestAI();
            IPlayer p2 = new TestAI();
            Game g = new Game(p1, p2);
            Assert.AreEqual(null, g.WhoWon());
        }

        /// <summary>
        /// Testing a legal move on a blank board
        /// </summary>
        [TestMethod]
        public void TestLegalMoveSunshine()
        {
            IPlayer p1 = new TestAI();
            IPlayer p2 = new TestAI();
            Game g = new Game(p1, p2);
            Placement placement = new Placement(0, 0);
            Assert.AreEqual(true, g.IsLegalMove(placement));
        }

        /// <summary>
        /// Testing non legal move on board with 1 occupied space
        /// Since the AI will always start at (2,2) the next placement has been put there
        /// </summary>
        [TestMethod]
        public void TestLegalMoveNotLegal()
        {
            IPlayer p1 = new TestAI();
            IPlayer p2 = new TestAI();
            Game g = new Game(p1, p2);
            g.NextMove();
            Placement placement = new Placement(2, 2);
            Assert.AreNotEqual(true, g.IsLegalMove(placement));
        }
    }
}
