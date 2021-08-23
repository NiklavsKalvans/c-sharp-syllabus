using CalculateArea;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Arithmetics10.Tests
{
    [TestClass]
    public class Arithmetics10Tests
    {
        [TestMethod]
        public void AreaOfCircle_RadiusIsPositive_CanCalculate()
        {
            //Arrange
            double radius = 7.0;
            var expected = Convert.ToDouble(Math.PI) * radius * 2.0;

            //Act
            double result = Geometry.AreaOfCircle(radius);

            //Assert
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(result, 2));
        }

        [TestMethod]
        public void AreaOfCircle_RadiusIsNegative_ThrowException()
        {
            //Arrange
            double radius = -7.0;

            //Act
            Action act = () => Geometry.AreaOfCircle(radius);

            //Assert
            ArgumentException exception = Assert.ThrowsException<ArgumentException>(act);
            Assert.AreEqual("Radius must be a positive number", exception.Message);
        }

        [TestMethod]
        public void AreaOfRectangle_LenghtAndWidthIsPositive_CanCalculate()
        {
            //Arrange
            double lenght = 7.0;
            double width = 5.0;
            var expected = lenght * width;

            //Act
            double result = Geometry.AreaOfRectangle(lenght, width);

            //Assert
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(result, 2));
        }

        [TestMethod]
        public void AreaOfRectangle_LengthOrWidthIsNegative_ThrowException()
        {
            //Arrange
            double lenght = 7.0;
            double width = -5.0;

            //Act
            Action act = () => Geometry.AreaOfRectangle(lenght, width);

            //Assert
            ArgumentException exception = Assert.ThrowsException<ArgumentException>(act);
            Assert.AreEqual("Both lenght and width must be positive numbers", exception.Message);
        }

        [TestMethod]
        public void AreaOfTriangle_GroundAndHeightIsPositive_CanCalculate()
        {
            //Arrange
            double ground = 7.0;
            double height = 5.0;
            var expected = height * ground * 0.5;

            //Act
            double result = Geometry.AreaOfTriangle(ground, height);

            //Assert
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(result, 2));
        }

        [TestMethod]
        public void AreaOfTriangle_GroundhOrHeightIsNegative_ThrowException()
        {
            //Arrange
            double ground = -7.0;
            double height = 5.0;

            //Act
            Action act = () => Geometry.AreaOfTriangle(ground, height);

            //Assert
            ArgumentException exception = Assert.ThrowsException<ArgumentException>(act);
            Assert.AreEqual("Both base and height must be positive numbers", exception.Message);
        }
    }
}
