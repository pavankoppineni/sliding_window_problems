using Microsoft.VisualStudio.TestTools.UnitTesting;
using SlidingWindowProblems.MaxConsecutiveOnesII;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlidingWindowProblems.Tests.MaxConsecutiveOnesII
{
    [TestClass]
    public class MaxConsecutiveOnesIIV1Tests
    {
        private static IList<object[]> GetDataSetForTest()
        {
            var dataset = new List<object[]>();

            //Test case 1 : All values are 1
            dataset.Add(new object[]
            {
                new int[]{1, 1, 1, 1, 1, 1},
                6
            });

            //Test case 2 : All values are 0
            dataset.Add(new object[] { 
                new int[]{0, 0, 0, 0, 0},
                1
            });

            //Test case 3 : All values in odd position are 1
            dataset.Add(new object[] { 
                new int[]{1, 0, 1, 0, 1, 0},
                3
            });

            //Test case 4 : Values consists of both 1 and 0
            dataset.Add(new object[]
            {
                new int[]{0, 1, 1, 0, 1, 1, 1, 0},
                4
            });

            return dataset;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataSetForTest), DynamicDataSourceType.Method)]
        public void Given_BinaryArray_When_FindMaxLengthOfConsecutiveOnes_Then_ShouldReturnMaxLengthOfConsecutiveOnes(int[] values, int expectedResult)
        {
            //Given
            var problem = new MaxConsecutiveOnesIIV1();

            //When
            var actualResult = problem.Find(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
