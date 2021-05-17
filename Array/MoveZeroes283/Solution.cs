namespace MoveZeroes283
{
    /// <summary>
    /// 283. Move Zeroes: https://leetcode.com/problems/move-zeroes/
    /// Input: nums = [0,1,0,3,12]
    /// Output: [1,3,12,0,0]
    /// 
    /// Input: nums = [0]
    /// Output: [0]
    /// </summary>
    public class Solution
    {
        public void MoveZeroes(int[] nums) 
        {
            if(nums.Length < 2) return;

            int index = 0; 
            int nzIndex = 0; // non-zero index

            while(index < nums.Length)
            {
                if (nums[index] != 0) 
                {
                    (nums[index], nums[nzIndex]) = (nums[nzIndex], nums[index]);

                    nzIndex++;
                }

                index++;
            }
        }

        public void MoveZeroesTwo(int[] nums)
        {
            if(nums.Length < 2) return;

            int insertPos = 0;

            foreach(int item in nums)
            {
                if(item != 0)
                {
                    nums[insertPos++] = item;
                }
            }

            for (int i = insertPos; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}