/*
# 200. Number of Islands
Link: https://leetcode.com/problems/number-of-islands/
Difficulty: Medium
Date: 2026-10-16
Time: O(m * n)  Space: O(m * n) for the visited array and recursion stack
*/

public class Solution {
    public int NumIslands(char[][] grid) {
        bool[,] visited = new bool[grid.Length, grid[0].Length];
        int islandCount = 0;
        for(int i = 0; i < grid.Length; i++) {
            for(int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j] == '1' && visited[i, j] == false) {
                    Visit(grid,  i, j , visited);
                    islandCount++;
                }
            }
        }
        return islandCount;
    }

    private void Visit(char[][] grid, int i, int j, bool[,] visited) {
        visited[i, j] = true;
        if (Up(grid, visited, i, j)) {
            Visit(grid, i - 1, j, visited);
        } 
        if (Down(grid, visited, i, j)) {
            Visit(grid, i + 1, j , visited);
        }
        if (Left(grid, visited, i, j)) {
            Visit(grid, i , j - 1, visited);
        }
        if (Right(grid, visited, i, j)) {
            Visit(grid, i , j + 1, visited);
        }
    }

    private bool Up(char[][] grid, bool[,] visited, int i, int j) {
        i = i - 1;
        if (i >= 0 && grid[i][j] == '1' && !visited[i, j]) {
            return true;
        }
        return false;
    }

    private bool Down(char[][] grid, bool[,] visited, int i, int j) {
        i = i + 1;
        if (i < grid.Length && grid[i][j] == '1' && !visited[i, j]) {
            return true;
        }
        return false;
    }

    private bool Left(char[][] grid, bool[,] visited, int i, int j) {
        j = j - 1;
        if (j >= 0 && grid[i][j] == '1' && !visited[i, j]) {
            return true;
        }
        return false;
    }

    private bool Right(char[][] grid, bool[,] visited, int i, int j) {
        j = j + 1;
        if (j < grid[0].Length && grid[i][j] == '1' && !visited[i, j]) {
            return true;
        }
        return false;
    }
}
