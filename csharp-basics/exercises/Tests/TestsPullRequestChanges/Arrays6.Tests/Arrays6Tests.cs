using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Arrays6;

namespace Arrays6.Tests
{
    [TestClass]
    public class Arrays6Tests
    {
        [TestMethod]
        public void ArrayCopy_RandomNumberArray_CopiesToNewArray()
        {
            //Arrange
            var arr = new int[] { 11, 24, 23, 74, 5, 26, 88, 38, 9, 64 };

            //Act
            var arr2 = Program.ArrayCopy(arr);

            //Assert
            for (int i = 0; i < arr.Length; i++)
            {
                Assert.AreEqual(arr[i], arr2[i]);
            }

        }
        [TestMethod]
        public void ReplaceLast_RandomNumberArray_ReplacesLastNumber()
        {
            //Arrange
            var arr = new int[] { 11, 24, 23, 74, 5, 26, 88, 38, 9, 64 };
            int num = -7;

            //Act
            Program.ReplaceLast(arr, num);

            //Assert
            Assert.AreEqual(arr[arr.Length - 1], num);
        }
        [TestMethod]
        public void Array_RandomNumberArray_ValuesAreBetween1and100()
        {
            //Arrange
            var min = 1;
            var max = 100;

            //Act
            var arr = Program.RandomNumberArray();

            //Assert
            for (int i = 0; i < arr.Length; i++)
            {
                Assert.IsTrue(Enumerable.Range(min, max).Contains(arr[i]));
            }
        }
    }
}
