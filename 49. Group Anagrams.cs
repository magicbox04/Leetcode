public class Solution 
{
    public IList<IList<string>> GroupAnagrams(string[] strs) 
    {
        var rest = new Dictionary<string, List<string>>();

        foreach (string s in strs)
        {
            int[] arr = new int[26];
            foreach (char c in s)
            {
                arr[c-'a']++;
            }
            string returnVal = new string(String.Join(",", arr));
            if (!rest.ContainsKey(returnVal))
            {
                rest[returnVal] = new List<string>();
            }
            else
            {
                rest[returnVal].Add(s);
            }
        }

        return rest.Values.ToList<IList<String>>();   
    }
}
