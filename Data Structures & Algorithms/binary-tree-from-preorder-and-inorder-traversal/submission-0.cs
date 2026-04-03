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
    static Dictionary<int, int> map = new Dictionary<int, int>();
    static int[] p = null!;
    static int[] i = null!;

    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        map = new Dictionary<int, int>();
        for (int i = 0; i < inorder.Length; i++)
            map[inorder[i]] = i;
        p = preorder;
        i = inorder;
        return fn(0, preorder.Length - 1,0,inorder.Length-1);
    }
    /*
    pre - > root ,letf , right 
            p1,             p2

    in - > left  , root  ,right
            i1    rooti      i2

            rooti = map[pre[p1]];

    */



    private TreeNode fn(int p1, int p2, int i1, int i2)
    {
        int rooti = map[p[p1]];
        int leftl = rooti - i1;
        int rightl = i2 - rooti;
        var crnt = new TreeNode(p[p1]);
        if (leftl>0)
            crnt.left = fn(p1 + 1, p1 + leftl, i1, rooti - 1);
        if (rightl>0)
            crnt.right = fn(p2 - rightl + 1, p2, rooti + 1, i2);

                return crnt;
    }
}