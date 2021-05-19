using System;
using System.Threading.Tasks;

namespace MergeSortedArray88
{
    /// <summary>
    /// 88. Merge Sorted Array: https://leetcode.com/problems/merge-sorted-array/
    /// Special Case:
    /// Input: 
    /// [0]
    /// m = 0
    /// [1]
    /// n = 1
    /// 
    /// Output: 
    /// [1]
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Solution #1: insert and sort.
        /// Time Complexity: O((m+n)log(m+n))
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                nums1[m] = nums2[i];

                m++;
            }

            Array.Sort(nums1);
        }

        /// <summary>
        /// key points is the contraint:
        /// 
        /// Constraints:
        /// nums1.length == m + n
        /// nums2.length == n
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public void MergeTwo(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k--] = nums1[i--];
                }
                else
                {
                    nums1[k--] = nums2[j--];
                }
            }

            while (j >= 0)
            {
                nums1[k--] = nums2[j--];
            }

        }
    }
}