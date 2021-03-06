using System.Collections.Generic;

namespace ClimbingStairs70
{
    /// <summary>
    /// 70. Climbing Stairs: https://leetcode.com/problems/climbing-stairs/
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Solution #1: Brute Force: recursive without cache.
        /// This is got "Time Limit Exceeded" in leetcode.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int ClimbStairsWithoutCache(int n) 
        {
            if(n <= 3) return n;

            return ClimbStairs(n - 1) + ClimbStairs(n - 2);
        }

        /// <summary>
        /// Solution #2: recursive with cache.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int ClimbStairsWithCache(int n)
        {
            IDictionary<int, int> cache = new Dictionary<int, int>();

            return ClimbWithCache(n, cache);
        }

        private int ClimbWithCache(int n, IDictionary<int, int> cache)
        {
             if(n <= 3) return n;

            if (cache.ContainsKey(n))
            {
                return cache[n];
            }

            var result = ClimbWithCache(n - 1, cache) + ClimbWithCache(n - 2, cache);

            cache[n] = result;

            return result;
        }

        /// <summary>
        /// Solution #3: Fibonacci Number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int ClimbStairs(int n) 
        {
            if(n <= 3) return n;

            int f1 = 1;
            int f2 = 2;
            int f3 = 3;

            for (int i = 3; i <= n; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }

            return f3;
        }

        /// <summary>
        /// Solution #4: Dynamic Programming: dp[i]=dp[i−1]+dp[i−2]
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int ClimbStairDp(int n)
        {
            if(n <= 3) return n;

            int[] dp = new int[n + 1];

            dp[1] = 1;
            dp[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }
    }
}