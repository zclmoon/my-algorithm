namespace LinkedListCycle141
{
    /// <summary>
    /// 141. Linked List Cycle: https://leetcode.com/problems/linked-list-cycle/
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Record visited node.
        /// Time Complexity: O(N)
        /// Space Complexity: O(N)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool HasCycle(ListNode head)
        {
            if(head == null || head.next == null) return false;

            IDictionary<ListNode, int> visited = new Dictionary<ListNode, int>();

            while(head != null)
            {
                if(visited.ContainsKey(head))
                {
                    return true;
                }

                visited.Add(head, 1);

                head = head.next;
            }

            return false;
        }

        /// <summary>
        /// Floyd's cycle-finding algorithm
        /// Two points: Slow and Faster.
        /// Time Complexity: O(N)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool HasCycleTwo(ListNode head)
        {
            if(head == null || head.next == null) return false;

            ListNode slow = head; // move step by step
            ListNode faster = head; // move two steps at a time

            while(faster != null && faster.next != null)
            {
                slow = slow.next;
                faster = faster.next.next;

                if(slow == faster) return true;
            }

            return false;
        }
    }
}