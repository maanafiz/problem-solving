/*
# 53. Maximum Subarray
Link: https://leetcode.com/problems/maximum-subarray/
Difficulty: Medium
Date: 2026-10-18
Time: O(n)  Space: O(1)
*/

public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = nums[0];
        int localSum = nums[0];
        for(int i = 1; i < nums.Length; i++) {
            int newSum = localSum + nums[i];
            if (newSum > nums[i]) {
                localSum = newSum;
            } 
            else {
                localSum = nums[i];
            }

            if(localSum > maxSum) {
                maxSum = localSum;
            }
        }

        return maxSum;
    }
}
