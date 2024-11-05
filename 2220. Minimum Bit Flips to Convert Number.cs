public class Solution 
{
    public int MinBitFlips(int start, int goal) 
    {
        int result = start ^ goal;

        return BitSize(result);
    }

    public int BitSize(int a)
    {
        int count = 0;
        while (a != 0)
        {
            count += a & 1;
            a >>= 1;
        }
        return count;
    }
}