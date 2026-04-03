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
    bool flag =true;
        public bool IsBalanced(TreeNode root)
        {
            CalcMax(root);
            return flag;
        }
        private int CalcMax(TreeNode root)
        {
            int l = 0, r = 0;
            if (root?.left != null)
                l = CalcMax(root.left) + 1;
            if (root?.right != null)
                r = CalcMax(root.right) + 1;
            if (Math.Abs(l - r) > 1)
                flag = false;
            return Math.Max(l, r);
        }
}
