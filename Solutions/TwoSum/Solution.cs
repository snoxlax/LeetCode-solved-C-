namespace Solutions.TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            // Create a dictionary to store the difference and its index
            Dictionary<int, int> numMap = new Dictionary<int, int>();

            // Iterate through the array
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                // Check if the complement exists in the dictionary
                if (numMap.ContainsKey(complement))
                {
                    // If found, return the indices
                    return new int[] { numMap[complement], i };
                }

                // Otherwise, add the current number and its index to the dictionary
                numMap[nums[i]] = i;
            }

            // If no solution is found (though the problem guarantees one), return an empty array
            return new int[] { };
        }
    }
}