using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Arithmetics6;

namespace Arithmetics6.Tests
{
    [TestClass]
    public class Arithmetics6Tests
    {
        [TestMethod]
        public void CozaLozaWoza_Till33_EqualsToTestString()
        {
            //Arrange
            string test = "\n1 2 Coza 4 Loza Coza Woza 8 Coza Loza 11 \nCoza 13 Woza CozaLoza 16 17 Coza 19 Loza CozaWoza 22 \n23 Coza Loza 26 Coza Woza 29 CozaLoza 31 32 Coza ";
            string result;

            //Act
            result = Program.CozaLozaWoza(33);

            //Assert
            Assert.AreEqual(test, result);
        }
    }
}
