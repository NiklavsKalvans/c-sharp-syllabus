using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Account;

namespace ClassesAndObejcts12.Tests
{
    [TestClass]
    public class ClassesAndObejcts12Tests
    {
        [TestMethod]
        public void Account_CreatingNewAccount_NameTestAccountBalance100()
        {
            //Arrange
            var expected = new Account.Account("TestAccount", 100.0);

            //Act
            var testAccount = new Account.Account("TestAccount", 100.0);

            //Assert
            Assert.AreEqual(Convert.ToString(expected), Convert.ToString(testAccount));
        }

        [TestMethod]
        public void Withdrawal_Balance100_NewBalance80()
        {
            //Arrange
            var expected = new Account.Account("TestAccount", 80.0);
            var testAccount = new Account.Account("TestAccount", 100.0);

            //Act
            testAccount.Withdrawal(20);

            //Assert
            Assert.AreEqual(Convert.ToString(expected), Convert.ToString(testAccount));
        }

        [TestMethod]
        public void Deposit_Balance100_NewBalance120()
        {
            //Arrange
            var expected = new Account.Account("TestAccount", 120);
            var testAccount = new Account.Account("TestAccount", 100.0);

            //Act
            testAccount.Deposit(20);

            //Assert
            Assert.AreEqual(Convert.ToString(expected), Convert.ToString(testAccount));
        }

        [TestMethod]
        public void Balance_Balance100_Return100()
        {
            //Arrange
            var expected = 100d;
            var testAccount = new Account.Account("TestAccount", 100.0);

            //Act
            var result = testAccount.Balance();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Transfer_AccountBalance100Transfers20ToAccountBalance0_NewAccountBalanse80and20()
        {
            //Arrange
            var testAccount = new Account.Account("TestAccount", 100.0);
            var testAccount2 = new Account.Account("TestAccount2", 0.0);
            var expected1 = new Account.Account("TestAccount", 80.0);
            var expected2 = new Account.Account("TestAccount2", 20.0);

            //Act
            Program.Transfer(testAccount, testAccount2, 20.0);

            //Assert
            Assert.AreEqual(Convert.ToString(expected1), Convert.ToString(testAccount));
            Assert.AreEqual(Convert.ToString(expected2), Convert.ToString(testAccount2));
        }
    }
}
