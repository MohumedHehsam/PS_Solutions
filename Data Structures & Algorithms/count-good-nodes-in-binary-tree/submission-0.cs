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

        static int res;
        public int GoodNodes(TreeNode root)
        {
            res = 0;
            fn(root , root.val);
            return res;
        }

        private void fn(TreeNode root,int max)
        {
            if (root is null)
                return;

            if (root.val >= max)
                res++;
            fn(root.right, Math.Max(max, root.val));
            fn(root.left, Math.Max(max, root.val));

        }

}
