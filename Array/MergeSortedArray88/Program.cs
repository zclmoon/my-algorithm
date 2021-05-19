using System;
using CoderCMS.Alogrithm.Common;

namespace MergeSortedArray88
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input:");
            var nums1 = new int[] { 1, 3, 0, 0 };
            var nums2 = new int[] { 2, 4 };

            ArrayUtil.PrintIntArray(nums1);
            ArrayUtil.PrintIntArray(nums2);

            Solution solution = new Solution();
            solution.MergeThree(nums1, 2, nums2, 2);

            Console.WriteLine("Output:");
            ArrayUtil.PrintIntArray(nums1);
        }
    }
}
