using System;
namespace Solutions.RomanToInteger
{
    public class Program
    {
        public static void Run()
        {
            // Example input Roman numeral
            string s = "MCMXCIV";
            
            // Call the function and print the result
            Solution solution = new Solution();
            int result = solution.RomanToInt(s);
            Console.WriteLine("Integer value: " + result); // Expected output: 1994
        }
    }
}