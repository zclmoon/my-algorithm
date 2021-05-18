using CoderCMS.Alogrithm.Common;
using System.Collections.Generic;
using System;

namespace ThreeSum15
{
    public class Solution
    {
        /// <summary>
        /// 15. 3Sum: https://leetcode.com/problems/3sum/
        /// Time Complexity: O(N²)
        /// Space Complexity: O(logN)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (nums == null || nums.Length < 2) return result;

            // Sort is the key point for following duplicate element skip.
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                // Skip duplicate element, since the array is sorted.
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                int j = i + 1, k = nums.Length - 1;

                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];

                    if (sum > 0) k--;
                    if (sum < 0) j++;

                    if (sum == 0)
                    {
                        result.Add(new List<int>() { nums[i], nums[j], nums[k] });

                        // Skip duplicate element, since the array is sorted.
                        while (j < k && nums[j] == nums[j + 1]) j++;
                        while (j < k && nums[k] == nums[k - 1]) k--;

                        j++;
                        k--;
                    }
                }
            }

            return result;
        }
    }
}