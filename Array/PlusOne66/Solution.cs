using System;

namespace PlusOne66
{
    /// <summary>
    /// 66. Plus One: https://leetcode.com/problems/plus-one/
    /// 
    /// Input: digits = [9,9,9,9]
    /// Output: [1,0,0,0,0]
    /// Explanation: The array represents the integer 4321.
    /// </summary>
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            if (digits.Length < 1) return new int[] { 0 };

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i] += 1;

                if (digits[i] <= 9) return digits;

                digits[i] = 0;
            }

            int[] result = new int[digits.Length + 1];
            result[0] = 1;

            return result;
        }


        /// <summary>
        /// This is the same with above solution
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public int[] PlusOneSolutionTwo(int[] digits)
        {
            if (digits.Length < 1) return new int[] { 0 };

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    // Any element is not 9, will return at here.

                    digits[i] += 1;

                    return digits;
                }
            }

            // All elements are 9
            int[] result = new int[digits.Length + 1];
            result[0] = 1;

            return result;
        }
    }
}