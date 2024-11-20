public class Solution 
{
    public int[] TopKFrequent(int[] nums, int k) 
    {
        Dictionary<int, int> count = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (!count.ContainsKey(num))
            {
                count.Add(num, 0);
            }
            count[num]++;
        }

        var sortedDict = count.OrderByDescending(kvp => kvp.Value).ToList();
        int[] returnArr = new int[k];
        for (int i = 0; i < k; i++)
        {
            returnArr[i] = sortedDict[i].Value;
        }
        return returnArr;
    }
}
