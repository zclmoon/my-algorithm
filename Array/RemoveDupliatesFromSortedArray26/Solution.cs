namespace RemoveDupliatesFromSortedArray26
{
    /// <summary>
    /// 26. Remove Duplicates from Sorted Array: https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Input: nums = [0,0,1,1,1,2,2,3,3,4]
        /// Output: 5, nums = [0,1,2,3,4]
        /// 
        /// Time Complexity: O(N);
        /// Space Complexity: O(1);
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int i = 0;

            for (int j = 1; j < nums.Length; j++)
            {
                if(nums[i] != nums[j])
                {
                    nums[++i] = nums[j];
                }
            }

            return i + 1; // start from index 0, so the Length is: i + 1
        }
    }
}