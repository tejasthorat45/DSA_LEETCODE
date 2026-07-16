/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {

        //using space hashset
        HashSet<ListNode> visited = new HashSet<ListNode>();

        while(head != null){
            if(visited.Contains(head))
            return head;
            visited.Add(head);
            head=head.next;
        }

        return null;

        
    }
}