/*
# 322. Coin Change
Link: https://leetcode.com/problems/coin-change/
Difficulty: Medium
Date: 2026-10-28
Time: O(amount * coins)  Space: O(amount)
*/

class Solution {
    public int coinChange(int[] coins, int amount) {
        if (coins.length == 0) {
            return -1;
        }
        int[] solves = new int[amount+1];
        for(int i = 1; i <= amount; i++) {
            solves[i] = amount + 1;
            for (int coin : coins) {
                if (i >= coin) {
                    int diff = i - coin;
                    solves[i] = Math.min(solves[i], solves[diff] + 1); 
                }
            }
        }
        return solves[amount] == amount+1 ? -1 : solves[amount];
    }
}
