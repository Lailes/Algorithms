using Sorting.Algorithms;
using Xunit;

namespace Algorithms.Tests {
    public class QuickTests {
        
        [Theory]
        [InlineData(new [] {1,2,3,4,5}, new [] {1,2}, new [] {3}, new [] {4,5})]
        [InlineData(new [] {1,4,9,8,5}, new [] {1,4,8,5}, new []{9}, null)]
        [InlineData(new [] {1}, null, new [] {1}, null)]
        public void TestTransfer(int[] array, int[] arr1, int[] arr2, int[] arr3) {
            var alg = new QuickSort<int>();
            var (a, b, c) = alg.Transfer(array);
            Assert.Equal(arr1, a);
            Assert.Equal(arr2, b);
            Assert.Equal(arr3, c);
        }

        [Theory]
        [InlineData(new [] {1,2,3}, new [] {4,5,6}, new [] {7,8,9}, new [] {1,2,3,4,5,6,7,8,9})]
        public void TestJoin(int[] arr1, int[] arr2, int[] arr3, int[] result) {
            var alg = new QuickSort<int>();
            var a = alg.Join(arr1, arr2, arr3);
            Assert.Equal(result, a);
        }
        
        [Theory]
        [InlineData(new[] {3, 1, 8, 5, 6, 1, 2, 3, 0, 8, 4, 12, 11, 14, 17, 20, 19, 18},
            new[] {0, 1, 1, 2, 3, 3, 4, 5, 6, 8, 8, 11, 12, 14, 17, 18, 19, 20})]
        public void TestSort(int[] input, int[] ideal) => Assert.Equal(ideal, new QuickSort<int>().Sort(input));
    }
}