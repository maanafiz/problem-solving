/*
# 560. Subarray Sum Equals K
Link: https://leetcode.com/problems/subarray-sum-equals-k/
Difficulty: Medium
Date: 2026-10-18
Time: O(n)  Space: O(n)
*/

public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int result = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        dict.Add(0, 1);
        int runingSum = 0;

        for(int i = 0; i < nums.Length; i++) {
            runingSum+= nums[i];
            int diff = runingSum - k;
            if (dict.TryGetValue(diff, out int diffOccurance)) {
                result += diffOccurance;
            }

            dict.TryGetValue(runingSum, out int runingSumOcc);
            dict[runingSum] = runingSumOcc + 1;
        }

        return result;
    }
}
