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
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null || list2 == null)
                return list1 ?? list2;

            ListNode res1 = null;
            ListNode res = null;
            if (list1.val < list2.val)
            { res1 = list1; list1 = list1.next; }
            else
            { res1 = list2; list2 = list2.next; }
            res = res1;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                { res.next = list1; list1 = list1.next; }
                else
                { res.next = list2; list2 = list2.next; }
                res = res.next;
            }
            while (list1 != null)
            {
                res.next = list1;
                res = res.next;
                list1 = list1.next;
            }
            while (list2 != null)
            {
                res.next = list2;
                res = res.next;
                list2 = list2.next;
            }
            return res1;
        }
}