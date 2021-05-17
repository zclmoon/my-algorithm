using System;
using CoderCMS.Alogrithm.Common;

namespace ReverserLinkedListTopN
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
            var topN = 10;

            var testList = ListNodeUtil.InitAIntList(listNumber);

            Console.WriteLine("Linked List before reverse:");
            ListNodeUtil.PrintLinkedList(testList);

            Solution solution = new Solution();

            ListNode result = null;

            switch (method)
            {
                case "1":
                    result = solution.ReverseN(testList, topN);
                    break;
                case "2":
                    result = solution.ReverseNTwo(testList, topN);
                    break;
                default:
                    result = solution.ReverseN(testList, topN);
                    break;
            }

            Console.WriteLine("Linked List after reverse:");
            ListNodeUtil.PrintLinkedList(result);
        }
    }
}
