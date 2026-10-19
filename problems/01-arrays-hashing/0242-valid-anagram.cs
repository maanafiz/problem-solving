/*
# 242. Valid Anagram
Link: https://leetcode.com/problems/valid-anagram/
Difficulty: Easy
Date: 2026-10-18
Time: O(n)  Space: O(k), k = distinct characters
*/

public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) { return false; }
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach(char c in s) {
            int count = 0;
            dict.TryGetValue(c, out count);
            dict[c] = count + 1;
        }

        foreach(char c in t) {
            int count = 0;
            dict.TryGetValue(c, out count);
            dict[c] = count - 1;
            if (dict[c] == 0) {
                dict.Remove(c);
            }
        }
        return dict.Count == 0;
    }
}
