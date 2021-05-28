namespace BitwiseAnd
{
    /// <summary>
    /// 201. Bitwise AND of Numbers Range: https://leetcode.com/problems/bitwise-and-of-numbers-range/
    /// Given two integers left and right that represent the range [left, right], return the bitwise AND of all numbers in this range, inclusive.
    ///
    /// Input: left = 5, right = 7
    /// Output: 4
    /// Input: left = 0, right = 0
    /// Output: 0
    /// Input: left = 1, right = 2147483647
    /// Output: 0
    /// Constraints: 0 <= left <= right <= 2^31 - 1
    ///
    /// The main idea is: find the common prefix of m and n 's binary code.
    /// </summary>
    public class Solution
    {
        public int RangeBitwiseAnd1(int left, int right)
        {
            if (left <= 0) return 0;

            while (left < right)
            {
                right &= right -1;
            }

            return left & right;
        }


        public int RangeBitwiseAnd2(int left, int right)
        {
            if (left <= 0) return 0;

            int i = 0;

            while(left < right)
            {
                right >>= 1;
                left >>= 1;

                i++;
            }

            return left << i;
        }

        public int RangeBitwiseAnd(int left, int right)
        {
            return (right > left) ? (RangeBitwiseAnd(left >> 1, right >> 1) << 1) : left;
        }
    }
}