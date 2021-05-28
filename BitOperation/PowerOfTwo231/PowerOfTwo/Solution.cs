namespace PowerOfTwo
{
    /// <summary>
    /// 231. Power of Two: https://leetcode.com/problems/power-of-two/
    /// 
    /// Given an integer n, return true if it is a power of two. Otherwise, return false.
    /// An integer n is a power of two, if there exists an integer x such that n == 2^x.
    /// </summary>
    public class Solution
    {
        public bool IsPowerOfTwo1(int n)
        {
            if(n <= 0) return false;

            return (n & (n - 1)) == 0;
        }

        public bool IsPowerOfTwo2(int n)
        {
            if(n <= 0) return false;

            while(n % 2 == 0)
            {
                n /= 2;
            }

            return n == 1;
        }
    }
}