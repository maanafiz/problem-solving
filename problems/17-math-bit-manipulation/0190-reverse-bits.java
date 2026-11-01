/*
# 190. Reverse Bits
Link: https://leetcode.com/problems/reverse-bits/
Difficulty: Easy
Date: 2026-10-30
Time: O(1), always 32 iterations  Space: O(1)
*/

class Solution {
    public int reverseBits(int n) {
        int result = 0;
        int i = 1;
        while(i <= 32) {
            result = (result << 1) | (n & 1);
            n = n >> 1;
            i++;
        }
        return result;
    }
}
