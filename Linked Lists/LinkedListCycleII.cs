public class Solution {
    public ListNode DetectCycle(ListNode head) {
        if(head == null || head.next == null){
            return null;
        }
        
        ListNode slow = head;
        ListNode fast = head.next.next;
        
        while(slow != fast){
            if(fast == null || fast.next == null){
                return null;
            }
            
            slow = slow.next;
            fast = fast.next.next;
        }
        
        ListNode start = head;
        bool nodeFound = false;
        
        while(!nodeFound){
            do {
                fast = fast.next;
                if(fast == start){
                    nodeFound = true;
                }
            }
            while(fast != slow && !nodeFound);
            
            if(!nodeFound){
                start = start.next;
            }
        }
        
        return start;
    }
}