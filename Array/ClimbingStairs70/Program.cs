using System;

namespace ClimbingStairs70
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int result = solution.ClimbStairDp(8);

            Console.WriteLine($"{result}");
        }
    }
}
