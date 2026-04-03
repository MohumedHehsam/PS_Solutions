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
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                var crnt = q.Dequeue();
                if(crnt.left != null)
                    q.Enqueue(crnt.left);
                if(crnt.right != null)
                    q.Enqueue(crnt.right);

                if(crnt.val == subRoot?.val)
                 if(TreeMethod(crnt,subRoot))
                 return true;
            }
            return false;
        }
        public bool TreeMethod(TreeNode p, TreeNode q)
        {
            if(p == null && q == null) return true;
            if ((p == null) != (q == null) || p?.val != q?.val)
                return false;

            var left = TreeMethod(p?.left, q?.left);
            var right = TreeMethod(p?.right, q?.right);

            return left&&right;
        }

}
