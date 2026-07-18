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

        //store in Lisy 
        List<ListNode> nodes = new List<ListNode>();
        

        // adde the nodes tothe list
        while(head != null){

            nodes.Add(head);
            head=head.next;
        }

        return nodes[nodes.Count/2];


        
    }
}