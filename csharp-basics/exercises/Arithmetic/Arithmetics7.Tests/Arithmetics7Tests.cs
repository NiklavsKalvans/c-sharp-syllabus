using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GravityCalculator;

namespace Arithmetics7.Tests
{
    [TestClass]
    public class Arithmetics7Tests
    {
        [TestMethod]
        public void CalculatePosition_Time10s_Minus490point5()
        {
            //Arrange
            double time = 10.0;
            double expected = -490.5;
            double result;

            //Act
            result = Program.CalculatePosition(time);

            //Assert
            Assert.AreEqual(Math.Round(expected, 1), Math.Round(result, 1));
        }
    }
}
