using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise_6_test
{
    [TestClass]
    public class ArrayExercise6Tests
    {
        [TestMethod]
        public void Array_ArrayRandomNumbers_CopiedAndReplacedLast()
        {
            int[] arr = new int[] { 29, 25, 72, 48, 59, 88, 3, 55, 46, 33 };
            int[] arr2 = new int[arr.Length];
            int num = -7;
            CopyArrayAndReplaceLast(arr, arr2, num);
        }
    }
}
