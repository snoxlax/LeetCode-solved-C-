using System;
namespace Solutions.ContainsDuplicate
{
    public class Program
    {
        public static void Run()
        {
            // Example input array
            int[] nums = { 1, 2, 3, 1 };

            // Create an instance of the Solution class
            Solution solution = new Solution();

            // Call the function and print the result
            bool result = solution.ContainsDuplicate(nums);
            Console.WriteLine("Contains duplicate? " + result); // Expected output: True
        }
    }
}