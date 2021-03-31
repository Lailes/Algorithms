using System;

namespace DataStructures {
    public class Stack<T> {

        private T[] arrayStack;
        private int index;

        public Stack(int initialSize = 10) => arrayStack = new T[initialSize];
        

        public int Length => index;

        public void Push(T item) {
            if (index == arrayStack.Length) {
                var newStack = new T[arrayStack.Length + arrayStack.Length / 2];
                Array.Copy(arrayStack, newStack, arrayStack.Length);
                arrayStack = newStack;
            }
            arrayStack[index++] = item;
        }

        public T Peek() {
            if (index == 0) {
                throw new NoItemsException();
            }
            return arrayStack[index - 1];
        }

        public T Pop() {
            if (index == 0) {
                throw new NoItemsException();
            }
            return arrayStack[index--];
        }

        public void Clear() => index = 0;
    }


    [Serializable]
    public class NoItemsException : Exception {
        public NoItemsException() { }
        public NoItemsException(string message) : base(message) { }
        public NoItemsException(string message, Exception inner) : base(message, inner) { }
        protected NoItemsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
