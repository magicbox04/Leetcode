public class Solution 
{
    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] output = new int[nums.Length];
        int num = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (j != i)
                {
                    num *= nums[j];
                }
            }
            output[i] = num;
            num = 1;

        }        
        return output;
    }
}