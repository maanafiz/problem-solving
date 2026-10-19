/*
# 56. Merge Intervals
Link: https://leetcode.com/problems/merge-intervals/
Difficulty: Medium
Date: 2026-10-19
Time: O(n log n)  Space: O(n) for the output (sort is in place)
*/

public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length == 0) return intervals;
        List<int []> mergedList = new List<int []>();
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        
        int[] lastInterval = intervals[0];
        for(int i = 1; i < intervals.Length; i++) {
            if (lastInterval[1] >= intervals[i][0]) {      
                lastInterval[1] = Math.Max(lastInterval[1], intervals[i][1]);  
            } 
            else {
                mergedList.Add(lastInterval);
                lastInterval = intervals[i];
            }
        }

        mergedList.Add(lastInterval);
        return mergedList.ToArray();
    }
}
