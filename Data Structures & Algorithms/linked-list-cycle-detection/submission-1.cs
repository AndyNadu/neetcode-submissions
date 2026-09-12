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
    public bool HasCycle(ListNode head) {
        if (head is null || head.next is null) {
            return false;
        }

        var slow = head.next;
        var fast = head.next.next;

        while (slow != fast && fast is not null) {
            slow = slow.next;
            fast = fast.next.next;
        }       

        return fast is not null;
    }
}