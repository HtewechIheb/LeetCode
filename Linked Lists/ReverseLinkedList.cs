/*** Recursive ***/

public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head == null){
            return null;
        }
        else if(head.next == null){
            return head;
        }
        else {
            ListNode newHead = ReverseList(head.next);

            head.next.next = head;
            head.next = null;
            
            return newHead;
        }
    }
}

/*** Iterative ***/

public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head == null){
            return null;
        }
        else if(head.next == null){
            return head;
        }
        else {
            ListNode current = head.next;
            ListNode temp;
            
            head.next = null;
            
            while(current != null){
                temp = current.next;
                current.next = head;
                head = current;
                current = temp;
            }
            
            return head;
        }
    }
}
