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

public class Solution
{
    static int max = -1001;
    static bool flag = true;
    List<int> res = null;
    public bool IsValidBST(TreeNode root)
    {
        max = -1001;
        flag = true;
        fn(root);
        return flag;
    }

    private void fn(TreeNode root)
    {
        if (root.left is not null)
            fn(root.left);

        if (root.val <= max)
        {
            flag = false;
            return;
        }
        else
            max = root.val;
        
        if (root.right is not null)
            fn(root.right);

    }

}