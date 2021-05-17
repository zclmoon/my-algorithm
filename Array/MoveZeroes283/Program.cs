using System;
using CoderCMS.Alogrithm.Common;

namespace MoveZeroes283
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = new int[] {1,0,1};

            Console.WriteLine("Before moving zeroes: ");
            ArrayUtil.PrintIntArray(testArr);


            Console.WriteLine("After moving zeroes: ");
            Solution solution = new Solution();
            solution.MoveZeroesTwo(testArr);
            ArrayUtil.PrintIntArray(testArr);
        }
    }
}
