public class Solution 
{
    public int RemoveElement(int[] nums, int val) 
    {
        int index = 0;
        int endIndex = nums.Length -1;
        int unqiue = 0;
        while (index < nums.Length && index < endIndex + 1)
        {
            if (nums[index] != val)
            {
                unqiue++;
                index++;
            }
            else
            {
                nums[index] = nums[endIndex];
                endIndex--;
            }
        }
        return unqiue;
    }
}