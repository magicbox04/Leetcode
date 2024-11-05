public class Solution {
    public int[] XorQueries(int[] arr, int[][] queries) 
    {
        int [] result = new int [queries.Length];
        int output;  
        
        for (int i = 0; i < queries.Length; i++)
        {
            int start = queries[i][0]; 
            int end = queries[i][1];
            output = arr[start];
            for (int j = start + 1; j <= end; j++)
            {
                output = arr[j] ^ output; 
            }

            result[i] = output;
        }

        return result;
    }
}