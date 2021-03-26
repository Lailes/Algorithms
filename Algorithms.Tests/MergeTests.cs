using Sorting.Algorithms;
using Xunit;

namespace Algorithms.Tests
{
    public class MergeTests
    {

        [Theory]
        [InlineData(new []{1,2,3,4},  new []{1,2}, new []{3,4})]
        [InlineData(new []{1,2,3},  new []{1}, new []{2,3})]
        [InlineData(new []{1,2},  new []{1}, new []{2})]
        [InlineData(new []{1},  new []{1}, null)]
        public void TestSplit(int[] array, int[] arr1, int[] arr2) {

            var alg = new MergeSort<int>();

            var (a, b) = alg.Split(array);
            Assert.Equal(arr1, a);
            Assert.Equal(arr2, b);
        }


        [Theory]
        [InlineData(new []{1,4,7}, new []{2,5,8}, new []{1,2,4,5,7,8})]
        [InlineData(new []{1,4,7}, null, new []{1,4,7})]
        [InlineData(null, new []{2,5,8}, new []{2,5,8})]
        [InlineData(new []{1,5,8}, new []{2,5,8}, new []{1,2,5,5,8,8})]
        [InlineData(new []{1,4}, new []{2,5,8}, new []{1,2,4,5,8})]
        [InlineData(new []{1}, new []{2,5,8}, new []{1,2,5,8})]
        public void TestMerge(int[] arr1, int[] arr2, int[] array) {
            var alg = new MergeSort<int>();
            var res = alg.Merge(arr1, arr2);
            Assert.Equal(array, res);
        }
        
        [Theory]
        [InlineData(new[] {3, 1, 8, 5, 6, 1, 2, 3, 0, 8, 4, 12, 11, 14, 17, 20, 19, 18},
            new[] {0, 1, 1, 2, 3, 3, 4, 5, 6, 8, 8, 11, 12, 14, 17, 18, 19, 20})]
        public void TestMergeSort(int[] input, int[] ideal) => Assert.Equal(ideal, new MergeSort<int>().Sort(input));
    }
}