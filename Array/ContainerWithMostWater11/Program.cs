using System;
using CoderCMS.Alogrithm.Common;

namespace ContainerWithMostWater11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            var testArr = new int[] {4,4,2,11,0,11,5,11,13,8};//ArrayUtil.InitIntArray(n);

            Console.WriteLine("Inited array:");
            ArrayUtil.PrintIntArray(testArr);

            Solution solution = new Solution();
            int maxArea = solution.MaxAreaThree(testArr);
            Console.WriteLine($"Max Area is: {maxArea}");
        }
    }
}
