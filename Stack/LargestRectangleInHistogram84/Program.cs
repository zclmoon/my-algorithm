using System;
using CoderCMS.Alogrithm.Common;

namespace LargestRectangleInHistogram84
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input");
            int[] testArr = new int[] { 2, 1, 5, 6, 2, 3 };
            // int[] testArr = new int[] { 1 };

            ArrayUtil.PrintIntArray(testArr);

            Solution solution = new Solution();
            var result = solution.LargestRectangleAreaThree(testArr);
            Console.WriteLine($"Output: {result}");
        }
    }
}
