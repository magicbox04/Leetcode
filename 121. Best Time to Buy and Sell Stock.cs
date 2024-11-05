public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        int minPrice = prices[0];
        int maxPrice= 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if(prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else if ((prices[i] - minPrice) > maxPrice) 
            {
                maxPrice = prices[i] - minPrice;
            }
        }

        return maxPrice;
    }
}