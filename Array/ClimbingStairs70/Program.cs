using System;

namespace ClimbingStairs70
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int result = solution.ClimbStairs(5);

            Console.WriteLine($"{result}");
        }
    }
}
