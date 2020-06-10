using _2ndLargestNumber;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int[] array = new int[] { 1, 4, 8, 2, 6, 0, 4, 7, 3 };
            int actualValue=Program.FindSecondLarge(array, 9);
            int expectedValue = 7;
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}