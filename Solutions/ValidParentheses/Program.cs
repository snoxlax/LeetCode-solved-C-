using System;
namespace Solutions.ValidParentheses
{
    public class Program
    {
        public static void Run()
        {
            // Example input
            string s1 = "[";
            string s2 = "{[]}";
            // Create an instance of the Solution class
            Solution solution = new Solution();

            // Call the TwoSum method and get the result
            bool result1 = solution.IsValid(s1);
            bool result2 = solution.IsValid(s2);
            // Print the result
            Console.WriteLine($"Indices: [{result1}, {result2}]"); // Output: Indices: [0, 1]
        }
    }
}