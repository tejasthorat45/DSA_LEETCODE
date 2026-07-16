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
    public bool HasCycle(ListNode head) {

        // HashSet<ListNode> visited = new HashSet<ListNode>();

        // while(head!=null){
        //     if(visited.Contains(head))
        //     return true;
        //     visited.Add(head);
        //     head=head.next;
        // }

        // return false;

        //optimal solution 0(1)

        //using the fast and slow ptr

        //edge case'
        if(head==null || head.next==null)
        return false;

        ListNode fast = head;
        ListNode slow = head;

        while(fast != null && fast.next!=null){

            slow=slow.next;
            fast=fast.next.next;

            if(slow==fast)
            return true;
        }

        return false;

        
    }
}