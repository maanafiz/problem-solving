/*
# 20. Valid Parentheses
Link: https://leetcode.com/problems/valid-parentheses/
Difficulty: Easy
Date: 2026-10-14
Time: O(n)  Space: O(n)
*/

public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>(s.Length);
        foreach(char c in s) {
            if (c == '(' || c == '{' || c == '[') {
                stack.Push(c);
            } else  if(stack.Count > 0) {
                char currentChar = stack.Peek();
                if (currentChar == '(' && c == ')') {
                    stack.Pop();
                } 
                else if (currentChar == '[' && c == ']') {
                    stack.Pop();
                } 
                else if (currentChar == '{' && c == '}') {
                    stack.Pop();
                }  
                else {
                    return false;
                }
            } else {
                return false;
            }
        }
        return stack.Count == 0 ? true : false;
    }
}
