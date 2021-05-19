namespace RotateArray189
{
    /// <summary>
    /// 189. Rotate Array: https://leetcode.com/problems/rotate-array/
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Solution #1: Extra Array.
        /// Time Complexity: O(n)
        /// Space Complexity: O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public void Rotate(int[] nums, int k)
        {
            if (nums.Length < 1 || k < 1) return;

            int[] newArray = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int newPos = (i + k) % nums.Length;

                newArray[newPos] = nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = newArray[i];
            }
        }

        /// <summary>
        /// Solution #2: Reverse Array.
        /// Time Complexity: O(n);
        /// Space Complexity: O(1);
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public void RotateWithReverse(int[] nums, int k)
        {
            if (nums.Length < 1 || k < 1) return;

            // Note
            k = k % nums.Length;

            ReverseArray(nums, 0, nums.Length - 1);
            ReverseArray(nums, 0, k - 1);
            ReverseArray(nums, k, nums.Length - 1);
        }

        private void ReverseArray(int[] nums, int start, int end)
        {
            while (start < end)
            {
                (nums[start], nums[end]) = (nums[end], nums[start]);

                start++;
                end--;
            }
        }

    }

}