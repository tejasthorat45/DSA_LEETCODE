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
    public ListNode DeleteMiddle(ListNode head) {

        // if(head == null || head.next==null)
        // return null;

        // //cal leb
        // int Len=0;
        // ListNode current = head;

        // while(current!=null){
        //     Len++;
        //     current=current.next;
        // }

        // int middle= Len/2;

        // current = head;

        // for(int i=0;i<middle-1;i++){

        //     current=current.next;


        // }

        // current.next=current.next.next;

        // return head;

        //optimal solution one pass solution

        //edge csaes
        if(head == null || head.next==null){
            return null;
        }

        ListNode slow =head;
        ListNode fast=head;
        ListNode prev = null;

        while(fast!=null && fast.next!=null){


            prev=slow;
            slow=slow.next;
            fast=fast.next.next;
        }

        prev.next=slow.next;

        return head;


        


    }
}