public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] output = new int[nums.Length];
        output[0] = 1;
        int temp = 1;
        int j = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            output[i] = temp * nums[j];
            temp *= nums[j];
            j++;
        }

        temp = nums[nums.Length - 1];
        j = nums.Length - 2;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            output[i] = temp * output[j];
            temp *= nums[j];
            j--;
        }
        
        return output;
    }
}