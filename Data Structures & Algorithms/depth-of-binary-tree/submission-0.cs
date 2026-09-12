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
    public int MaxDepth(TreeNode root) {
        return GetNodeDepth(root);
    }

    private int GetNodeDepth(TreeNode node) {
        if (node is null) {
            return 0;
        }
        
        if (node.left is null && node.right is null) {
            return 1;
        }

        return 1 + Math.Max(GetNodeDepth(node.left), GetNodeDepth(node.right));
    }
}