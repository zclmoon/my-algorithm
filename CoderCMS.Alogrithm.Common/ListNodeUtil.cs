using System;

namespace CoderCMS.Alogrithm.Common
{
    public static class ListNodeUtil
    {
        public static ListNode InitAIntList(int n) 
        {
            if(n < 1) return null;

            ListNode head = new ListNode(1, null);
            ListNode temp = head;

            int i = 2;
            while (i <= n) {
                ListNode node = new ListNode(i, null);
                temp.next = node;
                temp = node;

                i++;
            }

            return head;
        }

        public static void PrintLinkedList(ListNode head)
        {
            if (head == null)
            {
                Console.WriteLine("It is a empty list");
                
                return;
            }

            while (head != null)
            {
                Console.Write($"{head.val}");

                if (head.next != null) 
                {
                    Console.Write(" -> ");
                }

                head = head.next;
            }

            Console.WriteLine();
        }
    }
}