using CoderCMS.Alogrithm.Common;

namespace ReverserFullLinkedList206
{
    /// <summary>
    /// 206. Reverse Linked List: https://leetcode.com/problems/reverse-linked-list/
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Solution #1: Recursive.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode ReverseList(ListNode head) 
        {
            if(head == null || head.next == null) return head;

            ListNode last = ReverseList(head.next);

            head.next.next = head;
            head.next = null;

            return last;
        }

        /// <summary>
        /// Solution #2: Loop Linked List.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode ReverseListTwo(ListNode head)
        {
            ListNode current = head;
            ListNode prev = null;

            while (current != null)
            {
                (current.next, prev, current) = (prev, current, current.next);
            }

            return prev;
        }
    }
}