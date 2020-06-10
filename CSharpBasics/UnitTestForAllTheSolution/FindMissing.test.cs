using FindMissing;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class FindMissing
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int[] smallArray = new int[] { 6, 4, 5, 3, 8, 7, 2, 0, 1 };
            int[] bigArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            int actualValue = Program.Missing(bigArray, smallArray,10);
            int expectedValue = 9;
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void SearchTest()
        {
            int[] smallArray = new int[] { 6, 4, 5, 3, 8, 7, 2, 0, 1 };
            bool actualValue = Program.Search(smallArray,9,7);
            bool expectedValue = true;
            Assert.AreEqual(expectedValue, actualValue);

        }
    }
}