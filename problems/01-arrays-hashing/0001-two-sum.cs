/*
# 1. Two Sum
Link: https://leetcode.com/problems/two-sum/
Difficulty: Easy
Date: 2026-10-14
Time: O(n)  Space: O(n)
*/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>(nums.Length);

        for(int i = 0; i < nums.Length; i++) {
            int difference = target - nums[i];
            if (dict.TryGetValue(difference, out int result)) {
                return [i, result];
            }   
            dict[nums[i]] = i;
        }
        return [];
    }
}
