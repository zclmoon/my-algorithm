using CoderCMS.Alogrithm.Common;
using System;

namespace ReverserPartialLinkedList92
{
    class Program
    {
        static void Main(string[] args)
        {
                        var method = "1";
            if (args.Length == 1) 
            {
                method = args[0];
            }

            var listNumber = 10;
            var left = 3;
            var right = 8;

            var testList = ListNodeUtil.InitAIntList(listNumber);

            Console.WriteLine("Linked List before reverse:");
            ListNodeUtil.PrintLinkedList(testList);

            Solution solution = new Solution();

            ListNode result = null;

            switch (method)
            {
                case "1":
                    result = solution.ReverseBetween(testList, left, right);
                    break;
                case "2":
                    result = solution.ReverseBetween(testList, left, right);
                    break;
                default:
                    result = solution.ReverseBetween(testList, left, right);
                    break;
            }

            Console.WriteLine("Linked List after reverse:");
            ListNodeUtil.PrintLinkedList(result);
        }
    }
}
