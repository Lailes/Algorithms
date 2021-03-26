using System;

namespace Sorting.Algorithms
{
    public class BubbleSort<T> : ISorter<T> where T : IComparable<T>
    {
        public T[] Sort(T[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }
            
            for (var i = 0; i < array.Length - 1; i++)
            {
                for (var j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) == 0 || array[i].CompareTo(array[j + 1]) < 0 || array[j].CompareTo(array[j + 1]) <= 0)
                    {
                        continue;
                    }

                    var a = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = a;
                }
            }

            return array;
        }
    }
}
