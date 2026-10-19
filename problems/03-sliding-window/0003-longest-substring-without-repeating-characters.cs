/*
# 3. Longest Substring Without Repeating Characters
Link: https://leetcode.com/problems/longest-substring-without-repeating-characters/
Difficulty: Medium
Date: 2026-10-15
Time: O(n)  Space: O(k), k = distinct characters
*/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> dict = new Dictionary<char,int>();
        int maxLength = 0;
        int left = 0;
        int right = 0;
        foreach(char c in s) {
            int lastIndex = -1;

            if(dict.TryGetValue(c, out lastIndex)) { 
                left = Math.Max(left, lastIndex + 1) ;                
            }

            dict[c] = right;
            int currentLength = right - left + 1;
            if (maxLength < currentLength) {
                maxLength = currentLength;
            }
            right++;
        }

        return maxLength;
    }
}
