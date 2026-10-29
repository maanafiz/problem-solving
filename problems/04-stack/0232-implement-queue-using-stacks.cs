/*
# 232. Implement Queue using Stacks
Link: https://leetcode.com/problems/implement-queue-using-stacks/
Difficulty: Easy
Date: 2026-10-19
Time: O(1) amortized per operation  Space: O(n)
*/

public class MyQueue {
    Stack<int> reserver;
    Stack<int> server;
    public MyQueue() {
        reserver = new Stack<int>();
        server = new Stack<int>();
    }
    
    public void Push(int x) {
        reserver.Push(x);
    }
    
    public int Pop() {
        if (server.Count == 0) {
            Pour();
        }
        return server.Pop();
    }
    
    public int Peek() {
        if (server.Count == 0) {
            Pour();
        }
        return server.Peek();
    }
    
    public bool Empty() {
        return server.Count == 0 && reserver.Count == 0;
    }
    
    private void Pour() {
        while(reserver.Count != 0) {
            server.Push(reserver.Pop());
        }
    }
}
