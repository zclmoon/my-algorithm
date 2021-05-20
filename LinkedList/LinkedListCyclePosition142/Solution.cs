namespace LinkedListCyclePosition142
{
    public class Solution
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null) return null;

            ListNode slow = head; // move step by step
            ListNode faster = head; // move two steps at a time

            while (faster != null && faster.next != null)
            {
                slow = slow.next;
                faster = faster.next.next;

                if (slow == faster)
                {
                    ListNode starter = head;

                    while(starter != slow)
                    {
                        starter = starter.next;
                        slow = slow.next;
                    }

                    return starter;
                }
            }

            return null;
        }
    }
}