/*
# 2938. Separate Black and White Balls
Link: https://leetcode.com/problems/separate-black-and-white-balls/
Difficulty: Medium
Date: 2026-10-19
Time: O(n)  Space: O(1)
*/

public class Solution {
    public long MinimumSteps(string s) {
        long result = 0;
        int lastBlack = -1;
        int i = 0;
        foreach(char c in s) {
            if (c == '0') {
                int moves = (lastBlack == -1? i : (i - lastBlack - 1));
                result += moves;  
                lastBlack++;
            }
            i++;
        }
        return result;
    }
}
