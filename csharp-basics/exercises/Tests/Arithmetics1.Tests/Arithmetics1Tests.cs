using Exercise1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Arithmetics1.Tests
{
    [TestClass]
    public class Arithmetics1Tests
    {
        [TestMethod]
        public void IsEitherNumFifteenOrIsSumOrDiffFifteen_Num8AndNum7_true ()
        {
            //Arrange
            int num1 = 7;
            int num2 = 8;
            bool result;

            //Act
            result = Program.IsEitherNumFifteenOrIsSumOrDiffFifteen(num1, num2);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsEitherNumFifteenOrIsSumOrDiffFifteen_Num4AndNum10_false()
        {
            //Arrange
            int num1 = 4;
            int num2 = 10;
            bool result;

            //Act
            result = Program.IsEitherNumFifteenOrIsSumOrDiffFifteen(num1, num2);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsEitherNumFifteenOrIsSumOrDiffFifteen_Num15AndNum7_true()
        {
            //Arrange
            int num1 = 15;
            int num2 = 8;
            bool result;

            //Act
            result = Program.IsEitherNumFifteenOrIsSumOrDiffFifteen(num1, num2);

            //Assert
            Assert.IsTrue(result);
        }
    }
}
