using System;
namespace Solutions.Fibonacci
{
    public class Program
    {
        public static void Run()
        {
            int n = 0;
            Console.WriteLine("Enter the number of terms for Fibonacci series:");
            n = int.Parse(Console.ReadLine() ?? "0");
            Solution solution = new Solution();
            var result = solution.Fibonacci(n);
            Console.WriteLine(result);
        }
    }
}