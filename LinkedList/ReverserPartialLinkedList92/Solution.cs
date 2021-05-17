using CoderCMS.Alogrithm.Common;
using System;

namespace ReverserPartialLinkedList92
{
    /// <summary>
    /// 92. Reverse Linked List II: https://leetcode.com/problems/reverse-linked-list-ii/
    /// </summary>
    public class Solution
    {
        ListNode lastNodesNext = null;

        /// <summary>
        /// Solution #1: Recursive.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        private ListNode ReverseN(ListNode head, int n) 
        {
            if(head == null) return head;

            if (head.next == null || n == 1)
            {
                // Record last node's next node. (the n+1 node)
                lastNodesNext = head.next;

                return head;
            }

            ListNode last = ReverseN(head.next, n - 1);

            head.next.next = head;
            head.next = lastNodesNext;

            return last;
        }

        /// <summary>
        /// Solution #2: iterative.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        private ListNode ReverseNTwo(ListNode head, int n)
        {
            ListNode current = head;
            ListNode prev = null;

            while (current != null && n > 0)
            {
                (current.next, prev, current) = (prev, current, current.next);

                // var tmpCurrent = current;
                // var tmpNext = current.next;

                // current.next = prev;
                // prev = tmpCurrent;
                // current = tmpNext;

                if (n == 1) 
                {
                    head.next = current;
                }

                n--;
            }

            return prev;
        }

        public ListNode ReverseBetween(ListNode head, int left, int right) 
        {
            if (left == 1)
            {
                return ReverseN(head,right);
            }

            head.next = ReverseBetween(head.next, left - 1, right - 1);

            return head;
        }
    }
}