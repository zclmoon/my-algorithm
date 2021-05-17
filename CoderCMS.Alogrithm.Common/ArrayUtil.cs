using System;

namespace CoderCMS.Alogrithm.Common
{
    public static class ArrayUtil
    {
        public static int[] InitIntArray(int n)
        {
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                Random rnd = new Random();
                result[i] = rnd.Next(1, n);
            }

            return result;
        }

        public static void PrintIntArray(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Empty Array!");

                return;
            }

            foreach(int i in arr)
            {
                Console.Write($" {i} ");
            }

            Console.WriteLine();
        }
    }
}