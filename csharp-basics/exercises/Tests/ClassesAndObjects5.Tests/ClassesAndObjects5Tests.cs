using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercise_5;

namespace ClassesAndObjects5.Tests
{
    [TestClass]
    public class ClassesAndObjects5Tests
    {
        [TestMethod]
        public void DisplayDate_TestDate_ReturnsStringWithDateDevidedBySlash()
        {
            //Arrange
            var testDate = new Date(4, 8, 1997);
            var expected = "4/8/1997";

            //Act
            var result = Date.DisplayDate(testDate);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
