/*
# 110. Balanced Binary Tree
Link: https://leetcode.com/problems/balanced-binary-tree/
Difficulty: Easy
Date: 2026-10-18
Time: O(n)  Space: O(h), h = tree height (recursion stack)
*/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsBalanced(TreeNode root) {
        return CheckHeight(root) < 0 ? false : true;
    }

    public int CheckHeight(TreeNode root) {
        if (root == null) { return 0; }
        int leftHeight = root.left != null ? CheckHeight(root.left) : 0;
        int rightHeight = root.right != null ? CheckHeight(root.right) : 0;

        if (leftHeight == -1 || rightHeight == -1) { return -1; }

        if (Math.Abs(leftHeight - rightHeight) > 1) { return -1; }
        
        return (Math.Max(leftHeight, rightHeight) +  1);
    }
}
