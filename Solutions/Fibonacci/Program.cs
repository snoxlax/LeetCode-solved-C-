using System;
namespace Solutions.Fibonacci
{
    public class Program
    {
        public static void Run()
        {
           Console.WriteLine("Enter the number of terms for Fibonacci series:");
            int n = int.Parse(Console.ReadLine());

            Solution solution = new Solution();
            var result = solution.Fibonacci(n);
            Console.WriteLine(result);
        }
    }
}