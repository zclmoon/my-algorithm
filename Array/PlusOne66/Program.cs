using System;
using CoderCMS.Alogrithm.Common;

namespace PlusOne66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: ");

            var testArr = new int[] {9,9,9,9};

            ArrayUtil.PrintIntArray(testArr);

            Solution solution = new Solution();
            var result = solution.PlusOneSolutionTwo(testArr);

            Console.WriteLine($"Output: ");
            ArrayUtil.PrintIntArray(result);
        }
    }
}
