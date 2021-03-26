using System;
using Sorting.Algorithms;

namespace LaunchPad
{
    class Program
    {
        static void Main(string[] args)
        {
            var sorter = new BubbleSort<int>();
            var input = new[] {3, 1, 8, 5, 6, 1, 2, 3, 0, 8, 4, 12, 11, 14, 17, 20, 19, 18};
            
            foreach (var i in input)
            {   
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (var i in sorter.Sort(input))
            {   
                Console.Write(i + " ");
            }
        }
    }
}