/*
# 102. Binary Tree Level Order Traversal
Link: https://leetcode.com/problems/binary-tree-level-order-traversal/
Difficulty: Medium
Date: 2026-10-17
Time: O(n)  Space: O(n) for the queue (up to one full level)
*/

public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> traversed = new List<IList<int>>();
        if (root == null) { return traversed; }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Count > 0) {
            int newLevelSize = queue.Count;
            List<int> levelItems = new List<int>(newLevelSize);

            for(int i = 0; i < newLevelSize; i++) {
                TreeNode deueued = queue.Dequeue();
                levelItems.Add(deueued.val);

                if (deueued.left != null) { 
                    queue.Enqueue(deueued.left); 
                }
                if (deueued.right != null) { 
                    queue.Enqueue(deueued.right); 
                }
            }
            traversed.Add(levelItems);
        }

        return traversed;
        
    }
}
