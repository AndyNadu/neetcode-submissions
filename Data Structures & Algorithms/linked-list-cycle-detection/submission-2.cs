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

        var slow = head;
        var fast = head.next;

        while (slow != fast && fast is not null && fast.next is not null && fast.next.next is not null) {
            slow = slow.next;
            fast = fast.next.next;
        }       

        return slow == fast;
    }
}