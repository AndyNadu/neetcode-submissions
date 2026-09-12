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
        if (root is null) {
            return true;
        }

        var leftNodeHeight = CalculateNodeHeight(root.left);
        var rightNodeHeight = CalculateNodeHeight(root.right);

        return Math.Abs(leftNodeHeight - rightNodeHeight) <= 1;
    }

    private int CalculateNodeHeight(TreeNode root) {
        if (root is null) {
            return 0;
        }

        if (root.left is null && root.right is null) {
            return 1;
        }

        return 1 + Math.Max(CalculateNodeHeight(root.left), CalculateNodeHeight(root.right));
    }
}