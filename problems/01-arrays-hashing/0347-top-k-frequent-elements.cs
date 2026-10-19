/*
# 347. Top K Frequent Elements
Link: https://leetcode.com/problems/top-k-frequent-elements/
Difficulty: Medium
Date: 2026-10-16
Time: O(n + m log m)  Space: O(m), m = number of distinct values
*/

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> frequency = new Dictionary<int,int>();
        foreach(int num in nums) {
            int occurance = 0;
            frequency.TryGetValue(num, out occurance);
            frequency[num] = occurance + 1;
        }  

        return frequency.OrderByDescending(item => item.Value).Take(k).Select(item => item.Key).ToArray();
    }
}
