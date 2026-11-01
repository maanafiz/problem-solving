/*
# 55. Jump Game
Link: https://leetcode.com/problems/jump-game/
Difficulty: Medium
Date: 2026-10-31
Time: O(n)  Space: O(n) for the solves array
*/

class Solution {
    public boolean canJump(int[] nums) {
        int[] solves = new int[nums.length];
        int maxReach = 0;
        for(int i = 0; i < nums.length && i <= maxReach ; i++) {
            solves[i] = i + nums[i];
            if (maxReach < solves[i]) {
                maxReach = solves[i];
            }
        }
        return maxReach >= nums.length - 1;
    }
}
