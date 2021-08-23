using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercise2;

namespace Arithmetics2.Tests
{
    [TestClass]
    public class Arithmetics2Tests
    {
        [TestMethod]
        public void IsEvenNumber_NumberIs6_True()
        {
            //Arrange
            int num = 6;
            bool result;

            //Act
            result = Program.IsEvenNumber(num);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsEvenNumber_NumberIs3_False()
        {
            //Arrange
            int num = 3;
            bool result;

            //Act
            result = Program.IsEvenNumber(num);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
