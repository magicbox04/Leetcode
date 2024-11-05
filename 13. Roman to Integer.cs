public class Solution {
    public int RomanToInt(string s) 
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        dict['I'] =  1;
        dict['V'] =  5;
        dict['X'] =  10;
        dict['L'] =  50;
        dict['C'] =  100;
        dict['D'] =  500;
        dict['M'] =  1000;

        int result = 0;

        for (int i = 0; i < s.Length; i++) {
            if (i > 0 && dict[s[i]] > dict[s[i-1]]) 
            {
                result += dict[s[i]] - 2 * dict[s[i-1]];
            } 
            else 
            {
                result += dict[s[i]];
            }
        }

        return result;
    
    }
}