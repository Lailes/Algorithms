using System;

namespace Sorting.Algorithms
{
    public class MergeSort<T> : ISorter<T> where T : IComparable<T>
    {

        public (int[], int[]) Split(int[] arr)
        {
            if (arr.Length == 1)
            {
                return (arr, null);
            }

            var length = arr.Length;
            int i;
            for (i = 0; i < length / 2; i++)
            {
                
            }

            throw new NotImplementedException();
        }
        
        
        public T[] Sort(T[] array)
        {
            throw new NotImplementedException();
        }
    }
}