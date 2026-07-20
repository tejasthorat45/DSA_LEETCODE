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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {

        // ListNode current = head;
        // int L =0;


        // while(current!=null){

        //     L++;
        //     current=current.next;

        // }

        // if(n==L){
        //     return head.next;
        // }

        // current=head;

        // for(int i=1;i<L-n;i++){

        //     current=current.next;


        // }


        // current.next=current.next.next;

        // return head;


        //one pass solution

        ListNode dummy = new ListNode(0);
        dummy.next=head;

        ListNode slow =dummy;
        ListNode fast = dummy;

        for(int i=0;i<=n;i++){
            fast=fast.next;

        }

        while(fast!=null){

            slow=slow.next;
            fast=fast.next;
        }

        slow.next = slow.next.next;

        return dummy.next;


        
    }
}