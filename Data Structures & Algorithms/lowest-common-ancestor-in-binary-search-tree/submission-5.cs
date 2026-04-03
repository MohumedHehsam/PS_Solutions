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


        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode cmn = root;

            while (root != null)
            {
                if (root.val == p.val || root.val == q.val)
                    return root;
                    
                if (p.val > root.val && q.val > root.val)
                {
                    cmn = root;
                    root = root.right;
                }
                else if (p.val < root.val && q.val < root.val)
                {
                    cmn = root;
                    root = root.left;
                }
                else if((p.val>root.val)!=(q.val >root.val))
                    { cmn = root; break; }
            }
            return cmn;
        }

}
