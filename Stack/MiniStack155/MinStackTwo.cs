using System.Collections;
using System.Collections.Generic;
using System;

namespace MiniStack155
{
    public class MinStackTwo
    {
        int min = int.MaxValue;
        Stack<int> stack = null;

        public MinStackTwo()
        {
            stack = new Stack<int>();
        }

        public void Push(int val)
        {
            if (val <= min)
            {
                stack.Push(min); // push the min into stack as well.
                min = val;
            }

            stack.Push(val);
        }

        public void Pop()
        {
            if(stack.Peek() == min)
            {
                stack.Pop();
                min = stack.Pop();
            }
            else
            {
                stack.Pop();
            }
        }

        public int Top()
        {
           return stack.Peek();
        }

        public int GetMin()
        {
            return min;
        }
    }
}