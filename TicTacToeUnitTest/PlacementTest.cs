using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToeUnitTest
{
    [TestClass]
    public class PlacementTest
    {
        [TestMethod]
        public void TestPlacementDefaultConstructor()
        {
            Placement p = new Placement();
        }

        [TestMethod]
        [DataRow(26, -474)]
        public void TestPlacementConstructor(int x, int y)
        {
            Placement p = new Placement(x, y);
            Assert.AreEqual(x, p.X);
            Assert.AreEqual(y, p.Y);
        }

        [TestMethod]
        [DataRow(26, -474)]
        public void TestGetXAfterConstruct(int x, int y)
        {
            Placement p = new Placement(x, y);
            Assert.AreEqual(x, p.X);
        }

        [TestMethod]
        [DataRow(26, -474)]
        public void TestGetYAfterConstruct(int x, int y)
        {
            Placement p = new Placement(x, y);
            Assert.AreEqual(y, p.Y);
        }

        [TestMethod]
        [DataRow(-13, 272)]
        [DataRow(0, 0)]
        public void TestSetGet(int x, int y)
        {
            Placement p = new Placement();
            p.X = x;
            p.Y = y;
            Assert.AreEqual(x, p.X);
            Assert.AreEqual(y, p.Y);
        }

        [TestMethod]
        [DataRow(-13, 272)]
        [DataRow(0, 0)]
        public void TestToString(int x, int y)
        {
            Placement p = new Placement(x,y);
            string expected = "(" + x + ", " + y + ")";
            Assert.AreEqual(expected, p.ToString());
        }
    }
}
