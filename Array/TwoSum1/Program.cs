using System;
using CoderCMS.Alogrithm.Common;

namespace TwoSum1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = new int[] {2,7,11,15};
            int target = 17;

            Console.WriteLine("Input: ");
            ArrayUtil.PrintIntArray(testArr);

            Solution solution = new Solution();
            var result = solution.TwoSumSolutionTwo(testArr, target);

            Console.WriteLine("Output:");
            ArrayUtil.PrintIntArray(result);
        }
    }
}
