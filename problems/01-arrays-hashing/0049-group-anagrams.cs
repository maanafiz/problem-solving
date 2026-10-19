/*
# 49. Group Anagrams
Link: https://leetcode.com/problems/group-anagrams/
Difficulty: Medium
Date: 2026-10-15
Time: O(n * k)  Space: O(n * k), n = number of strings, k = max string length
*/

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {

        Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();

        foreach(string str in strs) {
            string key = PrepareKey(str);
            IList<string> list;
            if(!dict.TryGetValue(key, out list)) {
                list = new List<string>();
                dict.Add(key, list);
            }
            list.Add(str);
        }

        return dict.Values.ToList();
    }

    public string PrepareKey(string str) {
        char[] chars = new char[26];
        foreach(char c in str) {
            chars[c - 'a']++;
        }
        return new string(chars);
    }
}
