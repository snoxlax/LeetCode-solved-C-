using System;
namespace Solutions
{
    class GlobalProgram
    {
        static void Main()
        {
            Console.WriteLine("Running all LeetCode solutions...\n");

            // Run TwoSum solution
            Console.WriteLine("=== Two Sum ===");
            TwoSum.Program.Run();

            // Run ContainsDuplicate solution
            Console.WriteLine("\n=== Contains Duplicate ===");
            ContainsDuplicate.Program.Run();

            Console.WriteLine("\nAll solutions executed.");
        }
    }
}