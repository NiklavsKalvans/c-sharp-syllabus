using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FlightPlanner;
using System.IO;
using System.Collections.Generic;

namespace Collections6.Tests
{
    [TestClass]
    public class Collections6Tests
    {
        string Path = "../../flights.txt";
        [TestMethod]
        public void CreateCityAndDestinationDictionary_UsingFlightsText_CreatesDictionaryFromText()
        {
            //Arrange
            var readText = File.ReadAllLines(Path);
            var expected = new Dictionary<string, string>()
            {
                {"San Jose", ">San Francisco>Anchorage"},
                {"New York", ">Anchorage>San Jose>San Francisco>Honolulu"},
                {"Anchorage", ">New York>San Jose"},
                {"Honolulu", ">New York>San Francisco"},
                {"Denver", ">San Jose"},
                {"San Francisco", ">New York>Honolulu>Denver"}
            };

            //Act
            var result = Program.CreateCityAndDestinationDictionary(readText);

            //Assert
            foreach (KeyValuePair<string, string> kvp in result)
            {
                Assert.AreEqual(expected[kvp.Key], kvp.Value);
            }
        }
    }
}
