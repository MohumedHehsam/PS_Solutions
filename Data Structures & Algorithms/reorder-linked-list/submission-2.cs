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
        public void ReorderList(ListNode head)
        {
            List<ListNode> list = new List<ListNode>();
            ListNode res = new ListNode();
            
            while(head != null)
            {
                list.Add(head);
                head = head.next;
            }
            res= list[0];
            int l = 1, r = list.Count - 1;
            while(true)
            {

                if (l <= r)
                {
                    res.next = list[r];
                    r--;
                    res = res.next;
                }
                else
                    break;
                
                if (l<=r)
                {
                    res.next = list[l];
                    l++;
                    res = res.next;

                }
                else
                    break;
            }
            res.next = null;
        }}
