public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode prev = head;
        ListNode tail = head;
        
        for(int i = 0; i < n; i++){
            if(tail.next == null){
                head = head.next;
                return head;
            }
            
            tail = tail.next;
        }
        
        while(tail.next != null){
            prev = prev.next;
            tail = tail.next;
        }
        
        prev.next = prev.next.next;
        
        return head;
    }
}