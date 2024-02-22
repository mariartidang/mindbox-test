using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox;
using System;

namespace MindBox.Tests
{
    [TestClass]
    public class MindBoxTests
    {
        [TestMethod]
        public void GetSqure_10_314returned()
        {
            double x = 10;
            double expected = 314.1592653589793;

            SquareCalculator squareCalculator = new SquareCalculator();
            double actual = squareCalculator.GetSquare(x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSqure_4and6and4_7returned()
        {
            double x = 4;
            double y = 6;
            double z = 4;
            double expected = 7.94;

            SquareCalculator squareCalculator = new SquareCalculator();
            double actual = squareCalculator.GetSquare(x,y,z);

            Assert.AreEqual(expected, actual);
        }
    }
}
