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

            IDictionary<char, char> map = new Dictionary<char, char>()
            {
                {']','['},
                {')', '('},
                {'}', '{'},
            };

            foreach (char c in s)
            {
                switch(c)
                {
                    case '[':
                    case '(':
                    case '{':
                        stack.Push(c);
                        break;
                    case ']':
                    case '}':
                    case ')':
                        if(stack.Count == 0 || stack.Pop() != map[c]) return false;
                        break;
                }
            }

            return stack.Count == 0 ? true : false;
        }
    }
}