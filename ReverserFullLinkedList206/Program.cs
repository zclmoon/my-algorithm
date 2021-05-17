using System;
using CoderCMS.Alogrithm.Common;

namespace ReverserFullLinkedList206
{
    /// <summary>
    /// Test Commands: 
    /// 1. dotnet run
    /// 2. dotnet run 1
    /// 3. dotnet run 2
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var method = "1";
            if (args.Length == 1) 
            {
                method = args[0];
            }

            var testList = ListNodeUtil.InitAIntList(10);

            Console.WriteLine("Linked List before reverse:");
            ListNodeUtil.PrintLinkedList(testList);

            Solution solution = new Solution();

            ListNode result = null;

            switch (method)
            {
                case "1":
                    result = solution.ReverseList(testList);
                    break;
                case "2":
                    result = solution.ReverseListTwo(testList);
                    break;
                default:
                    result = solution.ReverseList(testList);
                    break;
            }

            Console.WriteLine("Linked List after reverse:");
            ListNodeUtil.PrintLinkedList(result);
        }
    }
}
