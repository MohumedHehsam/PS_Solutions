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
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode res = new ListNode(l1.val + l2.val);
            ListNode p = res;
            bool carry = res.val > 9 ? true : false;
            if (carry)
                res.val -= 10;
            l1 = l1?.next;
            l2 = l2?.next;
            while (l1 != null || l2 != null)
            {
                res.next = new ListNode(carry ? 1 : 0);
                res.next.val += (l1?.val ?? 0) + (l2?.val ?? 0);
                res = res.next;
                carry = res.val > 9 ? true : false;
                if (carry)
                    res.val -= 10;
                l1 = l1?.next;
                l2 = l2?.next;
            }
                if(carry)
                res.next = new ListNode(1);

            return p;
        }
}
