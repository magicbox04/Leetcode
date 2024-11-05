public class Solution 
{
    public string[] UncommonFromSentences(string s1, string s2) 
{
            string S = s1 + " " + s2;
            string[] splitS = S.Split(' ');
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (string str in splitS)
            {
                if (dict.ContainsKey(str))
                {
                    dict[str] += 1;
                }
                else
                {
                    dict[str] = 1;
                }
            }

            List<string> result = new List<string>();
            foreach (var entry in dict)
            {
                if (entry.Value == 1)
                {
                    result.Add(entry.Key);
                }
            }
            return result.ToArray();
        }
}