using NUnit.Framework;
using System.Collections.Generic;
using SelectionSort;
namespace Tests
{
    public class SelectionSort
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int[] listOfNumbers = new int[] { 6, 4, 5, 3, 8, 7, 2, 0, 9, 1 };
            int[] actualValue = Program.Sort(listOfNumbers,10);
            int[] expectedValue = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}