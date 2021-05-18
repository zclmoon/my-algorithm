using System.Collections.Generic;

namespace TwoSum1
{
    /// <summary>
    /// 1. Two Sum: https://leetcode.com/problems/two-sum/
    /// Input: nums = [2,7,11,15], target = 9
    /// Output: [0,1]
    /// 
    /// Input: nums = [3,2,4], target = 6
    /// Output: [1,2]
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Solution #1: tow interation
        /// Time Complexity: O(n²)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] {i, j};
                    }
                }
            }

            return new int[] { };
        }

        /// <summary>
        /// Solution #2: Hash Table / Dictionary, only one interation.
        /// Time Complexity: O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSumSolutionTwo(int[] nums, int target)
        {
            // key : array value
            // value : array index
            IDictionary<int, int> cache = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var item = target - nums[i];

                if (cache.ContainsKey(item)) 
                {
                    return new int[] {i, cache[item] };
                }

                cache.Add(nums[i], i);
            }

            return new int[] { };
        }
    }
}