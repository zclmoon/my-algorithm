using System;
using CoderCMS.Alogrithm.Common;

namespace ThreeSum15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input:");

            int[] testArr = new int[] {-1,0,1,2,-1,-4};

            ArrayUtil.PrintIntArray(testArr);

            Console.WriteLine("Output:");
            Solution solution = new Solution();
            var result = solution.ThreeSum(testArr);


            foreach (var trip in result)
            {
                foreach (var item in trip)
                {
                    Console.Write($"{item} ");
                }

                Console.WriteLine();
            }

        }
    }
}
