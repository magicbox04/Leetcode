public class Solution 
{
   public int FindTheLongestSubstring(string s) 
        {
            int bitmask = 0;
            int returnLength = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict[0] = -1;
            int index = 0;
            foreach (char character in s)
            {
                switch (character)
                {
                    case 'a':
                        bitmask ^= 1 << 0;
                        break;
                    case 'e':
                        bitmask ^= 1 << 1;
                        break; 
                    case 'i':
                        bitmask ^= 1 << 2;
                        break; 
                    case 'o':
                        bitmask ^= 1 << 3;
                        break; 
                    case 'u':
                        bitmask ^= 1 << 4;
                        break; 
                }
                
                if (dict.ContainsKey(bitmask))
                {
                    returnLength = Math.Max(returnLength, index - dict[bitmask]);
                }
                else
                {
                    dict[bitmask] = index;
                }
                index++;
            }
            return returnLength;
        }
}