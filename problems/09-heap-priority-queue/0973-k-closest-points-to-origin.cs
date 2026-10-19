/*
# 973. K Closest Points to Origin
Link: https://leetcode.com/problems/k-closest-points-to-origin/
Difficulty: Medium
Date: 2026-10-16
Time: O(n log n)  Space: O(n)
*/

public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        List<((int row, int col) Point, double Distance)> dict = new List<((int row, int col) Point, double Distance)>();
        foreach(int[] point in points) {
            double distance = getDistance(point[0], point[1]);
            dict.Add(((point[0], point[1]), distance));
        }
        return dict.OrderBy(x => x.Distance).Take(k).Select(y => new [] {y.Point.row, y.Point.col}).ToArray();
    }

    public double getDistance(int x, int y) {
        return Math.Sqrt((x * x) + (y* y));
    }
}
