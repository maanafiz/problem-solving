/*
# 91. Decode Ways
Link: https://leetcode.com/problems/decode-ways/
Difficulty: Medium
Date: 2026-10-29
Time: O(n)  Space: O(n)
*/

class Solution {
    public int numDecodings(String s) {
        int[] dp = new int[s.length() + 1];
        dp[0] = 1;
        int i = 0;
        while(i < s.length()) {
            if (i == 0) {
                dp[i + 1] = s.charAt(i) == '0' ? 0 : 1;
            } else {
                int pos1 = (int) s.charAt(i) - (int) '0';
                int pos10 = ((int) s.charAt(i-1) - (int) '0')* 10 + pos1;
                
                int value = 0;

                if (pos1 >= 1 && pos1 <= 9) {
                    value += dp[i];
                }

                if (pos10 >= 10 && pos10 <= 26) {
                    value += dp[i-1];
                }

                dp[i + 1] = value;
            }

            i++;
        }
        return dp[s.length()];
    }
}
