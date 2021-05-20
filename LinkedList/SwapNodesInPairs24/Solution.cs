namespace SwapNodesInPairs24
{
    /// <summary>
    /// 24. Swap Nodes in Pairs: https://leetcode.com/problems/swap-nodes-in-pairs/
    /// 
    /// Input: head = [1,2,3,4]
    /// Output: [2,1,4,3]
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Solution #1: Recursive.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode n = head.next;

            head.next = SwapPairs(head.next.next);

            n.next = head;

            return n;
        }

        public ListNode SwapPairsTwo(ListNode head)
        {
            var noValueHead = new ListNode(-1);

            ListNode pre = noValueHead;
            pre.next = head;

            while (pre.next != null && pre.next.next != null)
            {
                var first = pre.next;
                var second = first.next;

                (pre.next, second.next, first.next, pre) = (second, first, second.next, first);
            }

            return noValueHead.next;
        }
    }
}