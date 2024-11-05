public class Solution 
{
    public int MajorityElement(int[] nums) 
    {
        int n = nums.Length;
        Dictionary<int,int> myDic = new Dictionary<int, int>();

        foreach(int num in nums)
        {
            if (!myDic.ContainsKey(num))
            {
                myDic.Add(num,myDic.GetValueOrDefault(num,0) + 1);
            }
            else
            {
                myDic[num]+= 1;
            }
        }

        n = n/2;
        foreach (int key in myDic.Keys)
        {
            if (myDic[key] > n)
            {
                return key;
            }
        }
        return 0;
    }
}