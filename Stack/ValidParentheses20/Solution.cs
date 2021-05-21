using System;
using System.Collections.Generic;

namespace ValidParentheses20
{
    /// <summary>
    /// 20. Valid Parentheses: https://leetcode.com/problems/valid-parentheses/description/
    /// </summary>
    public class Solution
    {
        public bool IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;

            Stack<char> stack = new Stack<char>();

            IDictionary<char, char> map = new Dictionary<char, char>()
            {
                {']','['},
                {')', '('},
                {'}', '{'},
            };

            foreach (char c in s)
            {
                if (map.ContainsKey(c) && stack.Count != 0 && map[c] == stack.Peek())
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }

            return stack.Count == 0 ? true : false;
        }

        public bool IsValidTwo(string s)
        {
            if (s.Length % 2 != 0) return false;

            Stack<char> stack = new Stack<char>();

            IDictionary<char, char> map = new Dictionary<char, char>()
            {
                {']','['},
                {')', '('},
                {'}', '{'},
            };

            foreach(char c in s)
            {
                if(!map.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else if (stack.Count == 0 || map[c] != stack.Pop())
                {
                    return false;
                }
            }

            return stack.Count == 0 ? true : false;
        }

        public bool IsValidThree(string s)
        {
            if (s.Length % 2 != 0) return false;

            Stack<char> stack = new Stack<char>();

            foreach(char c in s)
            {
                if(c == '{')
                {
                    stack.Push('}');
                }
                else if(c == '[')
                {
                    stack.Push(']');
                }
                else if(c == '(')
                {
                    stack.Push(')');
                }
                else if( stack.Count == 0 || stack.Pop() != c)
                {
                    return false;
                }
            }

            return stack.Count == 0 ? true : false;
        }

        public bool IsValidFour(string s)
        {
            char[] stack = new char[s.Length];
            int head = 0;

            foreach(char c in s)
            {
                switch(c)
                {
                    case '{':
                    case '(':
                    case '[':
                        stack[head++] = c;
                        break;
                    case '}':
                        if(head == 0 || stack[--head] != '{') return false;
                        break;
                    case ']':
                        if(head == 0 || stack[--head] != '[') return false;
                        break;
                    case ')':
                        if(head == 0 || stack[--head] != '(') return false;
                        break;
                }
            }

            return head == 0;
        }
    }
}