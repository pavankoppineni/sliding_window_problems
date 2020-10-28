using Microsoft.VisualStudio.TestTools.UnitTesting;
using SlidingWindowProblems.MaxConsecutiveOnesIII;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlidingWindowProblems.Tests.MaxConsecutiveOnesIII
{
    [TestClass]
    public class MaxConsecutiveOnesIIIV1Tests
    {
        [TestMethod]
        public void Given_BinaryArrayAndNumberOfFlips_When_FindLongestConsecutiveOnes_Then_ShouldReturnLongestConsecutiveOnes()
        {
            //Given
            var values = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 };
            var problem = new MaxConsecutiveOnesIIIV1();
            var expectedLength = 6;
            var k = 2;

            //When
            var actualLength = problem.FindLongestConsecutiveOnes(values, k);

            //Then
            Assert.AreEqual(expectedLength, actualLength);
        }
    }
}
