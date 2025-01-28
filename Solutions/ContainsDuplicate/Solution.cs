using System;
using System.Collections.Generic;
namespace Solutions.ContainsDuplicate
{
public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        // Create a dictionary to track seen numbers
        Dictionary<int, int> hashmap = new Dictionary<int, int>();

        // Iterate through the array
        for (int i = 0; i < nums.Length; i++)
        {
            // If the number is already in the dictionary, it's a duplicate
            if (hashmap.ContainsKey(nums[i]))
            {
                return true;
            }
            // Otherwise, add it to the dictionary
            else
            {
                hashmap[nums[i]] = 1;
            }
        }

        // No duplicates found
        return false;
    }
}
}
    