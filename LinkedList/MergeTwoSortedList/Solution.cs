namespace MergeTwoSortedList
{
    /// <summary>
    /// 21. Merge Two Sorted Lists: https://leetcode.com/problems/merge-two-sorted-lists/
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Solution #1: Interation
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(0);
            ListNode head = dummy;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    dummy.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    dummy.next = l2;
                    l2 = l2.next;
                }

                dummy = dummy.next;
            }

            dummy.next = l1 == null ? l2 : l1;

            return head.next;
        }


        /// <summary>
        /// Solution #2: Recursive
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if(l1 == null) return l2;
            if(l2 == null) return l1;

            if(l1.val < l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }
        }
    }
}