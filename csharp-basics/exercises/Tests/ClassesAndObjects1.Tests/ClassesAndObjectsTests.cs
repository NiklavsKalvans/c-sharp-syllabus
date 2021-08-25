using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercise_1;

namespace ClassesAndObjects.Tests
{
    [TestClass]
    public class ClassesAndObjectsTests
    {
    
        [TestMethod]
        public void PrintProduct_TestProduct_PrintsNamePriceAndAmount()
        {
            //Arrange
            var test = new Product("Apple", 1.5, 7);
            var expected = "Apple, price 1.5, amount 7";

            //Act
            var result = test.PrintProduct();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ChangePrice_TestProduct_ChangePriceTo9()
        {
            //Arrange
            var test = new Product("Apple", 1.5, 7);
            var expected = "Apple, price 9, amount 7";

            //Act
            test.ChangePrice(9.0);
            var result = test.PrintProduct();

            //Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void ChangeAmount_TestProduct_ChangeAmountTo2()
        {
            //Arrange
            var test = new Product("Apple", 1.5, 7);
            var expected = "Apple, price 1.5, amount 2";

            //Act
            test.ChangeAmount(2);
            var result = test.PrintProduct();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
