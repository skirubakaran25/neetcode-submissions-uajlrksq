// This is a greedy + prefix minimum tracking problem.
public class Solution {
    public int MaxProfit(int[] prices) {

        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach(int price in prices)
        {
            if(price < minPrice)
            {
                minPrice = price;
            }
            else
            {
                int profit = price - minPrice;
                maxProfit = Math.Max(maxProfit, profit);
            }
        }
        return maxProfit;       
    }
}
