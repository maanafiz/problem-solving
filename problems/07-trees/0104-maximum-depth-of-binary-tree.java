/*
# 104. Maximum Depth of Binary Tree
Link: https://leetcode.com/problems/maximum-depth-of-binary-tree/
Difficulty: Easy
Date: 2026-10-31
Time: O(n)  Space: O(h), h = tree height (recursion stack)
*/

class Solution {
    public int maxDepth(TreeNode root) {
        if (root != null) {
            int leftDept = 0;
            if (root.left != null) {
                leftDept = maxDepth(root.left);
            }

            int rightDept = 0;
            if (root.right != null) {
                rightDept = maxDepth(root.right);
            }
            return Math.max(leftDept, rightDept) + 1;
        }
        return 0;
    }
}
