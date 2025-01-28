using System;
namespace Solutions.TwoSum
{
    public class Program
    {
        public static void Run()
        {
            // Example input
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            // Create an instance of the Solution class
            Solution solution = new Solution();

            // Call the TwoSum method and get the result
            int[] result = solution.TwoSum(nums, target);

            // Print the result
            Console.WriteLine($"Indices: [{result[0]}, {result[1]}]"); // Output: Indices: [0, 1]
        }
    }
}