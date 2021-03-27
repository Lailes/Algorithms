using System;

namespace Sorting.Algorithms {
    public class QuickSort<T> : ISorter<T> where T : IComparable<T> {

        public T[] Join(T[] arr1, T[] arr2, T[] arr3) {
            var arr = new T[(arr1?.Length ?? 0) + (arr2?.Length ?? 0) + (arr3?.Length ?? 0)];
            var index = 0;

            
            if (arr1 != null) {
                for (var i = 0; i < arr1.Length; i++) {
                    arr[index++] = arr1[i];
                }
            }

            if (arr2 != null) {
                for (var i = 0; i < arr2.Length; i++) {
                    arr[index++] = arr2[i];
                }
            }
            if (arr3 != null) {
                for (var i = 0; i < arr3.Length; i++) {
                    arr[index++] = arr3[i];
                }
            }
            
            return arr;
        }

        public (T[], T[], T[]) Transfer(T[] array) {
            if (array == null) {
                return (null, null, null);
            }

            if (array.Length == 1) {
                return (null, array, null);
            }


            var medium = array[array.Length / 2];

            var size1 = 0;
            var size2 = 0;
            var size3 = 0;
            foreach (var t in array) {
                switch (t.CompareTo(medium)) {
                    case < 0: {
                        size1++;
                        break;
                    }
                    case > 0: {
                        size3++;
                        break;
                    }
                    default: {
                        size2++;
                        break;
                    }
                }
            }

            var arr1 = new T[size1];
            var index1 = 0;
            var arr2 = new T[size2];
            var index2 = 0;
            var arr3 = new T[size3];
            var index3 = 0;
            
            foreach (var t in array) {
                switch (t.CompareTo(medium)) {
                    case > 0: {
                        arr3[index3++] = t;
                        break;
                    }
                    case < 0: {
                        arr1[index1++] = t;
                        break;
                    }
                    default: {
                        arr2[index2++] = t;
                        break;
                    }
                }
            }

            if (arr1.Length == 0) {
                arr1 = null;
            }
            if (arr2.Length == 0) {
                arr2 = null;
            }
            if (arr3.Length == 0) {
                arr3 = null;
            }
            
            return (arr1, arr2, arr3);
        }

        
        public T[] Sort(T[] array) {
            if (array == null || array.Length <= 1) {
                return array;
            }

            var (a, b, c) = Transfer(array);
            return Join(Sort(a), b, Sort(c));
        }
    }
}