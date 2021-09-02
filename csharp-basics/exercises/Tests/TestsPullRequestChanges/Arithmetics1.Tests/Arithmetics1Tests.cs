using Arithmetics1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Arithmetics1.Tests
{
    [TestClass]
    public class Arithmetics1Tests
    {
        [DataTestMethod]
        [DataRow(7, 8, true)]
        [DataRow(4, 10, false)]
        [DataRow(15, 8, true)]
        [DataRow(10, 25, true)]
        public void IsEitherNumFifteenOrIsSumOrDiffFifteen(int a, int b, bool c)
        {
            // Act
            var result = Program.IsEitherNumFifteenOrIsSumOrDiffFifteen(a, b);

            // Assert
            Assert.AreEqual(c, result);
        }
    }
}
