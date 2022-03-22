public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if(head == null || head.next == null){
            return head;
        }
        else {
            int length = 0;
            ListNode cur = head;
            
            while(cur != null){
                length++;
                cur = cur.next;
            }
            
            k = k % length;
            if(k == 0){
                return head;
            }
            
            cur = head;
            int counter = 1;
            
            while(counter < length - k){
                cur = cur.next;
                counter++;
            }
            
            ListNode newHead = cur.next;
            cur.next = null;
            cur = newHead;
            
            while(cur.next != null){
                cur = cur.next;
            }
            cur.next = head;
            head = newHead;
            
            return head;
        }
    }
}