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
        public List<int> RightSideView(TreeNode root)
        {
            var q = new Queue<TreeNode>();

            if (root != null)
                q.Enqueue(root);

            var res = new List<int>();

            while (q.Count > 0)
            {
                int? last=null;
                int i = q.Count;
                while (i-- > 0) 
                {
                    var x = q.Dequeue();
                    last = x.val;
                    if (x.left != null)
                    {
                        q.Enqueue(x.left);
                    }

                    if (x.right != null)
                    {
                        q.Enqueue(x.right);
                    }
                }
                if(last != null)
                res.Add((int)last);
            }
            return res;
        }

}
