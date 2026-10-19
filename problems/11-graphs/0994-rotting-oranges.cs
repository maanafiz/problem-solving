/*
# 994. Rotting Oranges
Link: https://leetcode.com/problems/rotting-oranges/
Difficulty: Medium
Date: 2026-10-17
Time: O(m * n)  Space: O(m * n) for the queue
*/

public class Solution {
    public int rows;
    public int cols;
    public int OrangesRotting(int[][] grid) {
        rows = grid.Length;
        cols = grid[0].Length;
        int globalTime = Visit(grid);

        for(int i = 0; i < rows; i++) {
            for(int j = 0; j < cols; j++) {
                if (grid[i][j] == 1) {
                    return -1;
                }
            }
        }

        return globalTime;
    }

    public int Visit(int[][] grid) {
        int mins = 0;
        Queue<(int i, int j)> queue = new Queue<(int i, int j)>();

        for(int i = 0; i < rows; i++) {
            for(int j = 0; j < cols; j++) {
                if (grid[i][j] == 2) {
                    queue.Enqueue((i, j));
                }
            }
        }
 
        while (queue.Count > 0) {
            
            int currentGeneration = queue.Count;
            bool newRotten = false;

            for(int p = 0; p < currentGeneration; p++) {
                var toVisit = queue.Dequeue();

                int i = toVisit.i;
                int j = toVisit.j;
                grid[i][j] = 3; // visited


                if ((i-1) >= 0 && j < cols && grid[i-1][j] == 1) { //up
                    grid[i-1][j] = 2;
                    queue.Enqueue((i-1,j));
                    newRotten = true;
                }

                if ((i+1) < rows && j < cols && grid[i+1][j] == 1) { //down
                    grid[i+1][j] = 2;
                    queue.Enqueue((i+1,j));
                    newRotten = true;
                }

                if (i < rows && (j-1) >= 0 && grid[i][j-1] == 1) { //left
                    grid[i][j-1] = 2;
                    queue.Enqueue((i,j-1));
                    newRotten = true;
                }

                if (i < rows && (j+1) < cols && grid[i][j+1] == 1) { //right
                    grid[i][j+1] = 2;
                    queue.Enqueue((i,j+1));
                    newRotten = true;
                }
            }

            if (newRotten) {
                mins++;
            }
        }
        return mins;
    }
}
