using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Polymorphism1;

namespace Polymorphism1.Tests
{
    [TestClass]
    public class Polymorphism1Tests
    {
        Bugati testCar = new Bugati();
        [TestMethod]
        public void SpeedUp_ExistingCar_SpeedIncreasedBy1()
        {
            //Arragne
            var expected = "1";

            //Act
            testCar.SpeedUp();
            var result = testCar.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SlowDown_ExistingCar_SpeedDecresedBy1()
        {
            //Arragne
            var expected = "1";

            //Act
            testCar.SpeedUp();
            testCar.SpeedUp();
            testCar.SlowDown();
            var result = testCar.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void UseNitrousOxideEngine_ExistingCarWithBoost_SpeedIncreasedby1()
        {
            //Arragne
            var expected = "2";

            //Act
            testCar.SpeedUp();
            testCar.UseNitrousOxideEngine();
            var result = testCar.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
