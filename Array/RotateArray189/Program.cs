using System;
using CoderCMS.Alogrithm.Common;

namespace RotateArray189
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 3;

            Console.WriteLine("Input: ");
            var testArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8};
            ArrayUtil.PrintIntArray(testArr);

            Console.WriteLine("Output: ");

            Solution solution = new Solution();
            solution.Rotate(testArr, k);
            ArrayUtil.PrintIntArray(testArr);
        }
    }
}
