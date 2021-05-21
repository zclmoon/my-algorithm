using System;
using System.Collections.Generic;

namespace LargestRectangleInHistogram84
{
    /// <summary>
    /// 84. Largest Rectangle in Histogram: https://leetcode.com/problems/largest-rectangle-in-histogram/
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Solution #1: Brute Force. calculate maxArea base on each emlement, then get the maximum one.
        /// got "Time Limit Exceeded" in leetcode.
        /// 
        /// Time Complexity: O(N²)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="heights"></param>
        /// <returns></returns>
        public int LargestRectangleArea(int[] heights)
        {
            int maxArea = 0;
            int len = heights.Length;

            if (len == 0) return 0;

            for (int i = 0; i < heights.Length; i++)
            {
                var currentHeight = heights[i];

                // Search the utmost higher (or of the same height) neighbors in left side.
                // Note: the elements' hight between the searched element and the current should all >= currentHeight.
                int left = i;
                while (left >= 0 && heights[left] >= currentHeight)
                {
                    left--;
                }

                // Search the utmost higher (or of the same height) neighbors in in right side.
                // Note: the elements' hight between the searched element and the current should all >= currentHeight.
                int right = i;
                while (right < len && heights[right] >= currentHeight)
                {
                    right++;
                }

                int width = right - left - 1;

                maxArea = Math.Max(maxArea, width * currentHeight);
            }

            return maxArea;
        }

        /// <summary>
        /// Solution #2: two cache the i's left/right utmost element's index.
        /// 
        /// Time Complexity: O(N)  -- why?
        /// Space Complexity: O(N)
        /// </summary>
        /// <param name="heights"></param>
        /// <returns></returns>
        public int LargestRectangleAreaTwo(int[] heights)
        {
            int maxArea = 0;
            int len = heights.Length;

            if (len == 0) return 0;

            int[] leftUtmostIdx = new int[len];
            int[] rightUtmostIdx = new int[len];

            leftUtmostIdx[0] = -1;
            rightUtmostIdx[len - 1] = len;

            // save left utmost elements for each item in heights
            // start from index 1, since the first element (index 0) has no left element.

            // Why the time complexity is O(N)?
            for (int i = 1; i < len; i++)
            {
                int left = i - 1;

                while (left >= 0 && heights[left] >= heights[i])
                {
                    // the i emlement's utmost element is same with (i - 1) if heights[i - 1] >= heights[i].
                    // this is key performance improvement than solution #1.
                    left = leftUtmostIdx[left];
                }

                leftUtmostIdx[i] = left;
            }

            // save right utmost elements for each item in heights
            // start from index len - 2, since the last element (index len - 1) has no right element.
            for (int i = len - 2; i >= 0; i--)
            {
                int right = i + 1;

                while (right < len && heights[right] >= heights[i])
                {
                    right = rightUtmostIdx[right];
                }

                rightUtmostIdx[i] = right;
            }

            for (int i = 0; i < len; i++)
            {
                maxArea = Math.Max(maxArea, (rightUtmostIdx[i] - leftUtmostIdx[i] - 1) * heights[i]);
            }

            return maxArea;
        }

        /// <summary>
        /// Solution #3: Monotone Stack
        /// </summary>
        /// <param name="heights"></param>
        /// <returns></returns>
        public int LargestRectangleAreaThree(int[] heights)
        {
            int len = heights.Length;

            Stack<int> stack = new Stack<int>();

            int maxArea = 0;

            for (int i = 0; i <= len; i++)
            {
                int h = (i == len ? 0 : heights[i]);

                if(stack.Count == 0 || h >= heights[stack.Peek()])
                {
                    stack.Push(i);
                }
                else
                {
                    int topH = stack.Pop();
                    maxArea = Math.Max(maxArea, heights[topH] * (stack.Count == 0 ? i : i - 1 - stack.Peek()));

                    i--;
                }
            }

            return maxArea;
        }
    }
}