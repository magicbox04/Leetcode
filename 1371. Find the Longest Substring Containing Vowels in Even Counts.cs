public class Solution {
    public int FindTheLongestSubstring(string s) 
    {
        int bitMask = 0;
        int maxLength = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int index = 0;
        dict[0] = -1;
        foreach(char a in s)
        {
            switch (a)
            {
                case 'a':
                    bitMask ^= 1;
                    break;
                case 'e':
                    bitMask ^= 1 << 1;
                    break;
                case 'i':
                    bitMask ^= 1 << 2;
                    break;
                case 'o':
                    bitMask ^= 1 << 3;
                    break;
                case 'u':
                    bitMask ^= 1 << 4;
                    break;
            } 

            if (dict.ContainsKey(bitMask))
            {
                maxLength = Math.Max(maxLength, index - dict[bitMask]);
            }
            else
            {
                dict[bitMask] = index;
            }
            index++;
        }
        return maxLength;
    }
}