using System;

namespace Sorting.Algorithms
{
    public class MergeSort<T> : ISorter<T> where T : IComparable<T>
    {

        public (T[], T[]) Split(T[] arr)
        {
            if (arr.Length == 1)
            {
                return (arr, null);
            }

            var length = arr.Length;
            var half = length / 2;
            int i;
            var arr1 = new T[half];
            var arr2 = new T[arr.Length - half];
            for (i = 0; i < half; i++)
            {
                arr1[i] = arr[i];
            }

            var a = 0;
            for (; i < arr.Length; i++) {
                arr2[a++] = arr[i];
            }

            return (arr1, arr2);
        }

        public T[] Merge(T[] arr1, T[] arr2) {
            if (arr1 == null && arr2 == null) {
                return null;
            }

            if (arr1 == null) {
                return arr2;
            }

            if (arr2 == null) {
                return arr1;
            }

            var result = new T[arr1.Length + arr2.Length];

            var index1 = 0;
            var index2 = 0;
            for (var i = 0; i < result.Length; i++) {
                if (index1 == arr1.Length && index2 == arr2.Length) {
                    break;
                }

                if (index1 == arr1.Length) {
                    result[i] = arr2[index2++];
                    continue;
                }
                if (index2 == arr2.Length) {
                    result[i] = arr1[index1++];
                    continue;
                }

                var a = arr1[index1];
                var b = arr2[index2];

                switch (a.CompareTo(b)) {
                    case 0:
                        result[i] = a;
                        index1++;
                        break;
                    case < 0:
                        result[i] = a;
                        index1++;
                        break;
                    default:
                        result[i] = b;
                        index2++;
                        break;
                }
            }

            return result;
        }
        
        
        public T[] Sort(T[] array) {
            if (array == null || array.Length == 1) {
                return array;
            }
            var (a, b) = Split(array);
            var result = Merge(Sort(a), Sort(b));
            return result;
        }
    }
}