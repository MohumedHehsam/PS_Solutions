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
        List<int> res =null;
        public bool IsValidBST(TreeNode root)
        {
            res = new List<int>();
            fn(root);
            if (root != null)
            {
                var max = -1001;
                foreach (var item in res)
                {
                    Console.WriteLine(item);
                    if(item > max)
                    {
                        max = item;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void fn(TreeNode root)
        {
            if(root.left is not null) 
                fn(root.left);
            res.Add(root.val);
            if(root.right is not null) 
                fn(root.right);

        }

}
