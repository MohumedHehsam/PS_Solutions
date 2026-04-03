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
        public TreeNode InvertTree(TreeNode root)
        {
            if (root is null) return null;

            if (root.left != null)
                InvertTree(root.left);
            if (root.right != null)
                InvertTree(root.right);
            
            if (root.left != null || root.right != null)
            {
                TreeNode temp = root.left;
                root.left = root.right;
                root.right = temp;
            }

            return root;
        }
}
