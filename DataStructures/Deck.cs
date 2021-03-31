using System;

namespace DataStructures {
    class Deck<T> {
        private T[] array;
        private int index = 0;

        public Deck(int length = 10) => array = new T[length];


        public void PushBack(T item) {
            throw new NotImplementedException();
        }

        public void PushFront(T item) {
            throw new NotImplementedException();
        }

        public T PopFront() {
            throw new NotImplementedException();
        }

        public T PopBack() {
            throw new NotImplementedException();
        }


    }
}
