public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] output = new int[nums.Length];
        int temp = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            output[i] = temp * nums[i];
            temp *= nums[i];
        }

        temp = 1;

        for (int i = nums.Length - 1; i > 0; i--)
        {
            output[i] = temp * nums[i];
            temp *= nums[i];
        }
        
        return output;
    }

}
