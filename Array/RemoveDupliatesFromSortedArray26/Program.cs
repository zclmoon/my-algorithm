using System;
using CoderCMS.Alogrithm.Common;

namespace RemoveDupliatesFromSortedArray26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: ");
            int[] testArr = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            ArrayUtil.PrintIntArray(testArr);

            Solution solution = new Solution();
            var result = solution.RemoveDuplicates(testArr);

            Console.WriteLine($"Output: {result}");
        }
    }
}
