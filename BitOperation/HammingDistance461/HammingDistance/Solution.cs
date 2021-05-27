using System;

namespace HammingDistance
{
    /// <summary>
    /// 461. Hamming Distance: https://leetcode.com/problems/hamming-distance/
    /// 
    /// The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
    /// Given two integers x and y, return the Hamming distance between them.
    /// </summary>
    public class Solution
    {
        public int HammingDistanceTwo(int x, int y)
        {
            string xBinaryStr = Convert.ToString(x, 2);
            int xlen = xBinaryStr.Length;

            string yBinaryStr = Convert.ToString(y, 2);
            int ylen = yBinaryStr.Length;

            int len = 0;

            if (xlen > ylen)
            {
                yBinaryStr = yBinaryStr.PadLeft(xlen, '0');
                len = xlen;
            }
            else
            {
                xBinaryStr = xBinaryStr.PadLeft(ylen, '0');
                len = ylen;
            }

            int result = 0;

            for (int i = 0; i < len; i++)
            {
                if (xBinaryStr[i] != yBinaryStr[i])
                {
                    result++;
                }
            }

            return result;
        }

        /// <summary>
        /// x: 1001
        /// y: 0010
        /// => n = x ^ y = 1010
        /// Count how may 1 in n binary => n &= n - 1 until n is 0.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int HammingDistance(int x, int y)
        {
            int count = 0;
            int n = x ^ y;

            while (n > 0)
            {
                count++;
                
                n &= n - 1;
            }

            return count;
        }
    }
}