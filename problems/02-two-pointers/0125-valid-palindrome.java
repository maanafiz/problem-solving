/*
# 125. Valid Palindrome
Link: https://leetcode.com/problems/valid-palindrome/
Difficulty: Easy
Date: 2026-10-29
Time: O(n)  Space: O(n) for the cleaned string
*/

class Solution {
    public boolean isPalindrome(String s) {   
        boolean isPalindrome = true;
        String trimmed = trim(s);
        int i = 0;
        int j = trimmed.length() - 1;
        while (i < j) {
            if(trimmed.charAt(i) != trimmed.charAt(j)) {
                isPalindrome = false;
                break;
            }
            i++;
            j--;
        }
        return isPalindrome;
    }

    public String trim(String s) {
        return s.toLowerCase().replaceAll("[^a-z0-9]", "");
    }
}
