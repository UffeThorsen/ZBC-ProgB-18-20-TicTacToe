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

        /// <summary>
        /// Tests the game constructer by giving it the same IPlayer variable.
        /// </summary>
        [ExpectedException(typeof(ArgumentException), AllowDerivedTypes = true)]
        [TestMethod]
        public void TestGameConstructorWithSamePlayerTwice() 
        {
            IPlayer p1 = new TestAI();
            Game g = new Game(p1, p1);
        }

        /// <summary>
        /// Tests if the games current player changes after NextMove is called.
        /// </summary>
        [TestMethod]
        public void TestGameIfChangePlayerChangesPlayer()
        {
            IPlayer p1 = new TestAI();
            IPlayer p2 = new TestAI();
            Game g = new Game(p1,p2);
            Symbol startPlayer = g.CurrentPlayer;
            g.NextMove();
            Assert.AreNotEqual(startPlayer, g.CurrentPlayer);
        }

        /// <summary>
        /// Tests if the game state has changed after NextMove is called.
        /// </summary>
        [TestMethod]
        public void TestGameNextMoveChangesGameState()
        {
            IPlayer p1 = new TestAI();
            IPlayer p2 = new TestAI();
            Game g = new Game(p1, p2);
            string state = g.ToString();
            g.NextMove();
            Assert.AreNotEqual(state, g.ToString());
        }

        /// <summary>
        /// Test if WhoWon is null on a blank game state.
        /// </summary>
        [TestMethod]
        public void TestWhoWonOnBlankBoard()
        {
            IPlayer p1 = new TestAI();
            IPlayer p2 = new TestAI();
            Game g = new Game(p1, p2);
            Assert.AreEqual(null, g.WhoWon());
        }

        /// <summary>
        /// Tests a legal move on a blank game state.
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
        /// Tests non legal move on board with 1 occupied space
        /// Since the AI will always start at (0,0) the next placement has been put there
        /// </summary>
        [TestMethod]
        public void TestLegalMoveOnOccupiedPlace()
        {
            IPlayer p1 = new TestAI();
            IPlayer p2 = new TestAI();
            Game g = new Game(p1, p2);
            g.NextMove();
            Placement placement = new Placement(0, 0);
            Assert.IsFalse(g.IsLegalMove(placement));
        }


        [ExpectedException(typeof(IndexOutOfRangeException))]
        [TestMethod]
        public void TestLegalMoveWithPositionOutsideOfGameSize()
        {
            IPlayer p1 = new TestAI();
            IPlayer p2 = new TestAI();
            Game g = new Game(p1, p2);
            g.IsLegalMove(new Placement(4, 4));
        }

        [DataTestMethod]
        [DataRow(7)]
        [DataRow(8)]
        [DataRow(9)]
        public void TestWhoWonWhenPlayerOneShouldHave(int turns)
        {
            IPlayer p1 = new TestAI();
            IPlayer p2 = new TestAI();
            Game game = new Game(p1, p2);
            for (int i = 0; i < turns; i++)
            {
                game.NextMove();
            }
            Assert.IsTrue(game.WhoWon() == p1);
        }

        [DataTestMethod]
        [DataRow(7)]
        [DataRow(8)]
        [DataRow(9)]
        public void TestIsGameDoneWhenShouldBeDone(int turns)
        {
            IPlayer p1 = new TestAI();
            IPlayer p2 = new TestAI();
            Game game = new Game(p1, p2);
            for (int i = 0; i < turns; i++)
            {
                game.NextMove();
            }
            Assert.IsTrue(game.IsGameDone);
        }
        //TODO Add Comment
        [TestMethod]
        public void TestIsGameDoneWhenShouldNotBeDone(int turns)
        {
            IPlayer p1 = new TestAI();
            IPlayer p2 = new TestAI();
            Game game = new Game(p1, p2);
            Assert.IsFalse(game.IsGameDone);
        }
    }
}
