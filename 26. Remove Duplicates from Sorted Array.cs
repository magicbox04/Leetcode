public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        int j = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[j] != nums[i])
            {
                j++;
                nums[j] = nums[i];
            }
        }
        return j+1;
    }
}
