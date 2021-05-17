using System;

namespace ContainerWithMostWater11
{
    /// <summary>
    /// 11. Container With Most Water: https://leetcode.com/problems/container-with-most-water/
    /// </summary>
    public class Solution
    {
        public int MaxArea(int[] height) 
        {
            int maxArea = 0;

            if (height == null || height.Length < 2)
            {
                return maxArea;
            }

            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * (right - left));

                if (height[left] < height[right])
                { 
                    left++; 
                }
                else
                {
                    right--;
                }
            }

            return maxArea;
        }

        public int MaxAreaTwo(int[] height) 
        {
            int maxArea = 0;

            if (height == null || height.Length < 2)
            {
                return maxArea;
            }

            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                int h = Math.Min(height[left], height[right]) ;
                maxArea = Math.Max(maxArea, h * (right - left));

                while (height[left] <= h && left < right) left++;
                while (height[right] <= h && left < right) right--;
            }

            return maxArea;
        }

        public int MaxAreaThree(int[] height)
        {
            int maxArea = 0;

            if (height == null || height.Length < 2)
            {
                return maxArea;
            }

            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * (right - left));
                var _ = height[left] > height[right] ? right-- : left++;
            }

            return maxArea;
        }
    }
}