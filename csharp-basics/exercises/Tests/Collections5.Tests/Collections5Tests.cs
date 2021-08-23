using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text.RegularExpressions;
using WordCount;

namespace Collections5.Tests
{
    [TestClass]
    public class Collections5Tests
    {
        string path = File.ReadAllText("../../lear.txt");
        [TestMethod]
        public void CountLines_UsingLearText_Retrun6Lines()
        {
            //Arrange
            string text = path;
            int expected = 6;

            //Act
            int result = Program.CountLines(text);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CountWords_UsingLearText_Retrun47Words()
        {
            //Arrange
            string string1 = Regex.Replace(path, "[?!,.']", " ");
            string string2 = Regex.Replace(string1, @"\s+", " ");
            string2 = string2.Remove(string2.Length - 1, 1) + ".";
            string text = string2;
            int expected = 47;
            
            //Act
            int result = Program.CountWords(text);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CountChars_UsingLearText_Retrun253Chars()
        {
            //Arrange
            string text = path;
            int expected = 253;

            //Act
            int result = Program.CountChars(text);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
