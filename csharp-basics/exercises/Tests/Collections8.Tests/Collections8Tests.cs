using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PhoneBook;

namespace Collections8.Tests
{
    [TestClass]
    public class Collections8Tests
    {
        [TestMethod]
        public void Find_FindAnExistingEntry_ReturnTrue()
        {
            //Arrange
            bool expected = true;
            PhoneDirectory testDirectory = new PhoneDirectory();
            testDirectory._data.Add("John", "+371 26589456");
            testDirectory._data.Add("Elvis", "+371 27775869");
            testDirectory._dataCount = 2;

            //Act
            var result = testDirectory.Find("John");

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Find_FindNonExistingEntry_ReturnFalse()
        {
            //Arrange
            bool expected = false;
            PhoneDirectory testDirectory = new PhoneDirectory();
            testDirectory._data.Add("John", "+371 26589456");
            testDirectory._data.Add("Elvis", "+371 27775869");

            //Act
            var result = testDirectory.Find("Vivian");

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetNumber_FindAnExistingNumberByName_ReturnNumber()
        {
            //Arrange
            string expected = "+371 26589456";
            PhoneDirectory testDirectory = new PhoneDirectory();
            testDirectory._data.Add("John", "+371 26589456");
            testDirectory._data.Add("Elvis", "+371 27775869");
            testDirectory._dataCount = 2;

            //Act
            var result = testDirectory.GetNumber("John");

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetNumber_FindNonExistingNumberByName_ReturnNull()
        {
            //Arrange
            PhoneDirectory testDirectory = new PhoneDirectory();
            testDirectory._data.Add("John", "+371 26589456");
            testDirectory._data.Add("Elvis", "+371 27775869");

            //Act
            var result = testDirectory.GetNumber("Alise");

            //Assert
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void PutNumber_NameOrNumberIsNull_ThrowException()
        {
            //Arrange
            PhoneDirectory testDirectory = new PhoneDirectory();
            testDirectory._data.Add("John", "+371 26589456");
            testDirectory._data.Add("Elvis", "+371 27775869");

            //Act
            Action act = () => testDirectory.PutNumber("Alise", null);

            //Assert
            ArgumentException exception = Assert.ThrowsException<ArgumentException>(act);
            Assert.AreEqual("name and number cannot be null", exception.Message);
        }

        [TestMethod]
        public void PutNumber_ExistingEntry_ReplaceOldNumber()
        {
            //Arrange
            string expected = "+371 99999999";
            PhoneDirectory testDirectory = new PhoneDirectory();
            testDirectory._data.Add("John", "+371 26589456");
            testDirectory._data.Add("Elvis", "+371 27775869");
            testDirectory._dataCount = 2;

            //Act
            testDirectory.PutNumber("John", "+371 99999999");

            //Assert
            Assert.AreEqual(expected, testDirectory._data["John"]);
        }

        [TestMethod]
        public void PutNumber_NewEntry_AddEntryToDictionary()
        {
            //Arrange
            int expected = 1;
            PhoneDirectory testDirectory = new PhoneDirectory();

            //Act
            testDirectory.PutNumber("Alise", "+371 99999999");

            //Assert
            Assert.AreEqual(expected, testDirectory._dataCount);
        }
    }
}
