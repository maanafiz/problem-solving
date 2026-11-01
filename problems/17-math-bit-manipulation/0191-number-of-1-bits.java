/*
# 191. Number of 1 Bits
Link: https://leetcode.com/problems/number-of-1-bits/
Difficulty: Easy
Date: 2026-10-30
Time: O(1), at most 32 iterations  Space: O(1)
*/

class Solution {
    public int hammingWeight(int n) {
        int count = 0;
        while(n != 0) {
            count += n & 1;
            n = n >>> 1;
        }
        return count;
    }
}
