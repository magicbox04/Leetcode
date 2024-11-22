public class Solution {
    public int[] TwoSum(int[] numbers, int target) 
    {
        int [] output = new int[2];
        int j = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            j = i;
            while (j < numbers.Length)
            {
                if (numbers[i] + numbers[j] == target && i != j)
                {
                    output [0] = i;
                    output[1] = j;
                }
                j++;
            }
        }

        return output;
    }


}
