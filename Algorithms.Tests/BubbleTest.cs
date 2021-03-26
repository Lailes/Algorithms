using System;
using Sorting.Algorithms;
using Xunit;

namespace Algorithms.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new[] {3, 1, 8, 5, 6, 1, 2, 3, 0, 8, 4, 12, 11, 14, 17, 20, 19, 18},
            new[] {0, 1, 1, 2, 3, 3, 4, 5, 6, 8, 8, 11, 12, 14, 17, 18, 19, 20})]
        public void TestBubbleSort(int[] input, int[] ideal) => Assert.Equal(ideal, new BubbleSort<int>().Sort(input));
    }
}