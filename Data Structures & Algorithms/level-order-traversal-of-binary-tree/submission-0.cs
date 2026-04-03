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

        public List<List<int>> LevelOrder(TreeNode root)
        {
            var q = new Queue<TreeNode>();
            if(root != null)
            q.Enqueue(root);
            var res = new List<List<int>>();
            var count = 1;
            while (q.Count > 0)
            {
                var crnList = new List<TreeNode>();
                var crntResList = new List<int>();

                while (count > 0) //moving current queue into new templist ,& adding them to resulting current level .
                {
                    var x = q.Dequeue();
                    crntResList.Add(x.val);
                    crnList.Add(x);
                    count--;
                }
                res.Add(crntResList);


                foreach (var crn in crnList) // looping on resulting level to extract it's children to queue again .and counting how many are they
                {
                    if (crn.left != null)
                    {
                        count++;
                        q.Enqueue(crn.left);
                    }

                    if (crn.right != null)
                    {
                        count++;
                        q.Enqueue(crn.right);
                    }

                }
            }
            return res;
        }

}
