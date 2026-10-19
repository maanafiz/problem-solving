/*
# 739. Daily Temperatures
Link: https://leetcode.com/problems/daily-temperatures/
Difficulty: Medium
Date: 2026-10-18
Time: O(n)  Space: O(n)
*/

public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] answers = new int[temperatures.Length];
        Stack<int> stack = new Stack<int>();

        for(int i = 0; i < temperatures.Length; i++) {  
            while(stack.Count != 0 && temperatures[stack.Peek()] < temperatures[i]) {
                answers[stack.Peek()] = i - stack.Peek();
                stack.Pop(); 
            }
            stack.Push(i);  
        }
        return answers;
    }
}
