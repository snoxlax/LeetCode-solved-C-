namespace Solutions.RomanToInteger
{
    public class Solution
    {
        public int RomanToInt(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>{
            
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 } 
            
            };

            int current = 0;
            int prev = 0;
            int total = 0;

            foreach (var ch in str)
            {
                current = dict[ch];
                if(current > prev){
                    total += current;
                }else{
                    total -= current;
                }
                prev = current;
            }
            return total;
        }
    }
}