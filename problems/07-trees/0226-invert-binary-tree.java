/*
# 226. Invert Binary Tree
Link: https://leetcode.com/problems/invert-binary-tree/
Difficulty: Easy
Date: 2026-10-31
Time: O(n)  Space: O(h), h = tree height (recursion stack)
*/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    public TreeNode invertTree(TreeNode root) {
        if (root != null) {
            if (root.left != null) {
                invertTree(root.left);
            }

            if (root.right != null) {
                invertTree(root.right);
            }

            TreeNode swap = root.left;
            root.left = root.right;
            root.right = swap;
        }
        return root;
    }
}
