/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
        public bool HasCycle(ListNode head)
        {
            HashSet<int> set = new HashSet<int>();
            while(head!=null)
            {
                if (set.Contains(head.val) == false)
                    set.Add(head.val);
                else
                    return true;
                head = head.next;
            }
            return false;
        }
}
