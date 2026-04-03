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

        static int kk;
        static bool flag = false;
        static int res;
        
        public int KthSmallest(TreeNode root, int k)
        {
            kk = k;
            flag = false;
            fn(root);
            return res;
        }

        private void fn(TreeNode root)
        {
            if (flag)
                return;
            if(root.left != null) 
                fn(root.left);
            kk--;
            if (kk == 0)
            {
                flag = true;
                res = root.val;
            }
            if(root.right != null)
                fn(root.right);
        }
}
