using System;

namespace ValidParentheses20
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "()()";

            Console.WriteLine($"Input: {input}");

            Solution solution = new Solution();
            var result = solution.IsValidFour(input);

            Console.WriteLine($"Output: {result}");
        }
    }
}
