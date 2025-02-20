using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using LinqAssignmentApp;  // Use your app's namespace

namespace LinqAssignment.Tests
{
    [TestClass]
    public class ArrayFunctionsTests
    {
        [TestMethod]
        public void TestGetEvenNumbers_NoSkip()
        {
            // Arrange: Create an array of 1,000,000 integers.
            var array = Enumerable.Range(0, 1_000_000).ToArray();

            // Act: Call the function to get even numbers with no skip.
            var evenNumbers = ArrayFunctions.GetEvenNumbers(array).ToList();

            // Assert: Verify that all numbers are even and the count is correct.
            Assert.IsTrue(evenNumbers.All(n => n % 2 == 0));
            Assert.AreEqual(500_000, evenNumbers.Count);
        }

        [TestMethod]
        public void TestGetEvenNumbers_WithSkip()
        {
            var array = Enumerable.Range(0, 1_000_000).ToArray();
            int skip = 10;

            var evenNumbers = ArrayFunctions.GetEvenNumbers(array, skip).ToList();

            Assert.AreEqual(500_000 - skip, evenNumbers.Count);
        }

        // Tests for the odd numbers function...
        [TestMethod]
        public void TestGetOddNumbersAfterShuffle_NoSkip()
        {
            var array = Enumerable.Range(0, 1_000_000).ToArray();
            var oddNumbers = ArrayFunctions.GetOddNumbersAfterShuffle(array).ToList();

            Assert.IsTrue(oddNumbers.All(n => n % 2 != 0));
            Assert.AreEqual(500_000, oddNumbers.Count);
        }

        [TestMethod]
        public void TestGetOddNumbersAfterShuffle_WithSkip()
        {
            var array = Enumerable.Range(0, 1_000_000).ToArray();
            int skip = 20;
            var oddNumbers = ArrayFunctions.GetOddNumbersAfterShuffle(array, skip).ToList();

            Assert.AreEqual(500_000 - skip, oddNumbers.Count);
        }

        // Test for the statistics function...
        [TestMethod]
        public void TestGetArrayStats()
        {
            var array = Enumerable.Range(0, 1_000_000).ToArray();
            var (average, minimum, maximum) = ArrayFunctions.GetArrayStats(array);

            Assert.AreEqual(0, minimum);
            Assert.AreEqual(999_999, maximum);
            double expectedAverage = (0 + 999_999) / 2.0;
            Assert.AreEqual(expectedAverage, average, 0.0001);
        }
    }
}
