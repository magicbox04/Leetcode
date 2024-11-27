public class Solution 
{
    public bool IsValid(string s) 
    {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> dictionary = new Dictionary<char, char>()
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        if (s.Length % 2 != 0)
        {
            return  false;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                stack.Push(s[i]);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                if (dictionary[s[i]] != stack.Pop())
                {
                    return false;
                }
            }
        }

        if (stack.Count != 0)
        return false;
        else
        return true;
    }
}


