/*
# 121. Best Time to Buy and Sell Stock
Link: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
Difficulty: Easy
Date: 2026-10-18
Time: O(n)  Space: O(1)
*/

public class Solution {
    public int MaxProfit(int[] prices) {
        int minBuy = prices[0];
        int maxProfit = 0;
        foreach (int price in prices) {
            minBuy = Math.Min(minBuy, price);
            maxProfit = Math.Max(maxProfit, price - minBuy);
        }
        return maxProfit;
    }
}
