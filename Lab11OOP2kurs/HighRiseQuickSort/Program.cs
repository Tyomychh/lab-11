using HighRiseQuickSort;
using System;

namespace HighRiseQuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = QuickSortClass.RandomArray(20);
            Console.WriteLine("Unsorted array: " + string.Join(", ", array));
            Console.WriteLine();

            QuickSortClass.BistraSortirovka(array, 0, array.Length - 1);
            Console.WriteLine("Sorted array: " + string.Join(", ", array));

            Console.ReadLine();
        }
    }
}