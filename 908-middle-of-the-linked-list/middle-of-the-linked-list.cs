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
    public ListNode MiddleNode(ListNode head) {

        // //store in Lisy 
        // List<ListNode> nodes = new List<ListNode>(); //O(n)
        

        // // adde the nodes tothe list
        // while(head != null){

        //     nodes.Add(head);
        //     head=head.next;
        // }

        // return nodes[nodes.Count/2];

        // second approach cal length of the LL

        ListNode current = head;
        int length=0;

        while(current!=null){
            length++;
            current=current.next;
        }

        for(int i=0;i<length/2;i++){
            head=head.next;
        }

        return head;


        
    }
}