public class Solution 
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        int count = 0;
        bool[] Alphabet = new bool[26];
        bool flag;
        
        foreach (char character in allowed)
        {
            Alphabet[character - 'a'] = true;
        }

        foreach (string word in words)
        {
            flag = true; 
            foreach (char character in word)
            {
                if (Alphabet[character - 'a'] == false)
                {
                    flag = false;
                    break;
                }
            }

            if (flag == true)
            {
                count++;
            }
        }
        return count;
    }
}