using System;

namespace MiniStack155
{
    public class MinStack
    {
        Node head = null;

        /** initialize your data structure here. */
        public MinStack()
        {

        }

        public void Push(int val)
        {
            if(head == null)
            {
                head = new Node(val, val, null);
            }
            else
            {
                head = new Node(val, Math.Min(head.min, val), head);
            }
        }

        public void Pop()
        {
            head = head.next;
        }

        public int Top()
        {
            return head.val;
        }

        public int GetMin()
        {
            return head.min;
        }

        private class Node
        {
            public int val;
            public int min;
            public Node next;

            public Node(int val, int min, Node next)
            {
                this.val = val;
                this.min = min;
                this.next = next;
            }
        }
    }
}