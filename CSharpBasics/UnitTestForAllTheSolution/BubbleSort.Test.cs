using NUnit.Framework;
using System.Collections.Generic;
using BubbleSort;

namespace Tests
{
    public class BubbleSort
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            List<int> listOfNumbers = new List<int>() { 6, 4, 5, 3, 8, 7, 2, 0, 9, 1 };
            List<int> actualValue = Program.Bubble(listOfNumbers);
            List<int> expectedValue = new List<int>(){ 0,1,2,3,4,5,6,7,8,9,};
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}