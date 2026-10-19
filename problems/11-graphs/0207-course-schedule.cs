/*
# 207. Course Schedule
Link: https://leetcode.com/problems/course-schedule/
Difficulty: Medium
Date: 2026-10-17
Time: O(V + E)  Space: O(V + E), V = courses, E = prerequisites
*/

public class Solution {
    public List<int>[] graph { get; set; }
    public bool CanFinish(int numCourses, int[][] prerequisites) {

        //prepare graph
        graph =  new List<int>[numCourses];
        for(int i = 0; i < graph.Length; i++) {
            graph[i] = new List<int>();
        }

        //populate graph & indegree
        int[] indegree = new int[graph.Length];
        for(int i = 0; i < prerequisites.Length; i++) {
            graph[prerequisites[i][1]].Add(prerequisites[i][0]);
            indegree[prerequisites[i][0]]++;
        }

        // Schedule calculation
        List<int> schedule = new List<int>(graph.Length);
        Queue<int> zeroDegreeNodes = getZeroDegreeNodes(indegree);
        int visitCount = 0;

        while(zeroDegreeNodes.Count() > 0) {
            int currentNode = zeroDegreeNodes.Dequeue();
            visitCount++;
            
            schedule.Add(currentNode);  
            foreach(var vertex in graph[currentNode]) {
                indegree[vertex]--;
                if(indegree[vertex] == 0) {
                    zeroDegreeNodes.Enqueue(vertex);
                }
            }   
        }
        return visitCount == graph.Length;
    }

    public Queue<int> getZeroDegreeNodes(int[] indegree) {
        Queue<int> nodes = new Queue<int>();
        for(int i = 0; i < indegree.Length; i++) {
            if (indegree[i] == 0) {
                nodes.Enqueue(i);
            }
        }
        return nodes;
    }
}
