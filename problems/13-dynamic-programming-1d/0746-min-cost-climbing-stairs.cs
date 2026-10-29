/*
# 746. Min Cost Climbing Stairs
Link: https://leetcode.com/problems/min-cost-climbing-stairs/
Difficulty: Easy
Date: 2026-10-19
Time: O(n)  Space: O(1)
*/

public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int length = cost.Length;
        for(int i = 2; i < cost.Length; i++){
            cost[i] = cost[i] + (cost[i - 1] < cost[i - 2] ? cost[i - 1] : cost[i - 2]);
        }

        return cost[length - 1] < cost[length - 2] ? cost[length - 1] : cost[length - 2];
    }
}
