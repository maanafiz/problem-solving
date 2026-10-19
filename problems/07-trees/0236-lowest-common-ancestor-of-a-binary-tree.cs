/*
# 236. Lowest Common Ancestor of a Binary Tree
Link: https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/
Difficulty: Medium
Date: 2026-10-17
Time: O(n)  Space: O(h), h = tree height (recursion stack)
*/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null) {
            return null;
        }

        TreeNode tn1 = LowestCommonAncestor(root.left, p, q);
        TreeNode tn2 = LowestCommonAncestor(root.right, p, q);

        if (tn1 != null && tn2 != null) {
            return root;
        }

        if (tn1 != null) {
            if (root.val == p.val || root.val == q.val) {
                return root;
            }
            return tn1;
        }

        if (tn2 != null) {
            if (root.val == p.val || root.val == q.val) {
                return root;
            }
            return tn2;
        }

        if (root.val == p.val || root.val == q.val) {
            return root;
        }
        return null;
    }
}
