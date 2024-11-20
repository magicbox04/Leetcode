 public class Solution {

    public string Encode(IList<string> strs) 
    {
        if (strs.Count == 0) return "";
        string output = "";

        foreach (string s in strs) 
        {
            output +=  s.Length + "#" + s;
        }

        return output;
    }

    public List<string> Decode(string s) 
    {
        if (s.Length == 0) 
        {
            return new List<string>();
        }
        List<string> output = new List<string>();
        int length = 0; 
        int j = 0;
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (c == '#') 
            {
                if (char.IsDigit(s[i-1]))
                {
                    length = int.Parse(s.Substring(j, i - j));
                    j = i + 1 + length;
                    output.Add(s.Substring(i + 1, length));
                }
            }
        }
        return output;
    }       
}