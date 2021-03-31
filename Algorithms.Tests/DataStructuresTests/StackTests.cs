
using DataStructures;

using Xunit;

namespace Algorithms.Tests.DataStructuresTests {
    public class StackTests {


        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(0)]
        public void TestLength(int elements) {
            var stack = new Stack<int>();
            for (int i = 0; i < elements; i++) stack.Push(i);
            Assert.Equal(elements, stack.Length);
        }
    }
}
