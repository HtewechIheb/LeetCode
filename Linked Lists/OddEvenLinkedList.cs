public class Solution {
    public ListNode OddEvenList(ListNode head) {
        if(head == null){
            return null;
        }
        else if(head.next == null){
            return head;
        }
  
        ListNode oddHead = head;
        ListNode evenHead = head.next;
        
        ListNode currentOdd = oddHead;
        ListNode currentEven = evenHead;
        ListNode current = head.next.next;
        int i = 1;
        
        while(current != null){
            if(i % 2 != 0){
                currentOdd.next = current;
                currentOdd = currentOdd.next;
            }
            else{
                currentEven.next = current;
                currentEven = currentEven.next;
            }
            
            i++;
            current = current.next;
        }
        
        currentEven.next = null;
        currentOdd.next = evenHead;
        
        return head;
    }
}