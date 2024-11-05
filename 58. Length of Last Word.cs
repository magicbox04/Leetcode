public class Solution 
{
    public int LengthOfLastWord(string s) 
    {
        string[] splitS = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            s = splitS[splitS.Length-1];
            return s.Length;  
    }
}