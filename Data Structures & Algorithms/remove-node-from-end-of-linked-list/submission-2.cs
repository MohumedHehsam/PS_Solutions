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
         public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode[] l = new ListNode[30];
            byte i = 0;
            ListNode p = head;
            while (p != null)
            {
                l[i++] = p;
                p = p.next;
            }
            if (i - n == 0)
                return l[0].next;
            else if(n==1)
            {
                l[i - 2].next = null;
                return head;
            }
            else
            {
                l[i - n - 1].next = l[i - n].next;
                return head;
            }
        }
}
