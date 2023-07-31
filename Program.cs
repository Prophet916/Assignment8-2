using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] arr = { 12, 11, 13, 5, 6, 7 };
                Console.WriteLine("Original Array:");
                PrintArray(arr);

                MergeSort.MergeSorted(arr);
                Console.WriteLine("\nSorted Array:");
                PrintArray(arr);
                Console.ReadKey();
            }
        }

        private static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
