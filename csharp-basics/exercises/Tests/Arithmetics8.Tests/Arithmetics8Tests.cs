using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercise8;

namespace Arithmetics8.Tests
{
    [TestClass]
    public class Arithmetics8Tests
    {
        [TestMethod]
        public void CalculateSalary_Worked40Hours_RecievesBasePay()
        {
            //Arrange
            double workersPay = 8.00;
            double hoursWorked = 40;
            double expected = workersPay * hoursWorked;
            double? result;

            //act
            result = Program.CalculateSalary(hoursWorked, workersPay);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateSalary_Worked60Hours_RecievesBasePayAndOvertime()
        {
            //Arrange
            double workersPay = 8.00;
            double hoursWorked = 60;
            double expected = workersPay * 40 + 20 * workersPay * 1.5;
            double? result;

            //act
            result = Program.CalculateSalary(hoursWorked, workersPay);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateSalary_Worked65Hours_RecievesNoPay()
        {
            //Arrange
            double workersPay = 8.00;
            double hoursWorked = 65;
            double? result;

            //act
            result = Program.CalculateSalary(hoursWorked, workersPay);

            //Assert
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void CalculateSalary_LessThanMinPay_RecievesNoPay()
        {
            //Arrange
            double workersPay = 6.00;
            double hoursWorked = 40;
            double? result;

            //act
            result = Program.CalculateSalary(hoursWorked, workersPay);

            //Assert
            Assert.AreEqual(null, result);
        }
    }
}
