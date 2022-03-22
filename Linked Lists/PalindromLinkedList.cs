public class Solution {
    public bool IsPalindrome(ListNode head) {
        if(head == null){
            return false;
        }
        else if(head.next == null){
            return true;
        }
        else {
            ListNode reverseHead = null;
            ListNode current = head;
            
            while(current != null){
                ListNode node = new ListNode(current.val, reverseHead);
                reverseHead = node;
                
                current = current.next;
            }
            
            current = head;
            ListNode reverseCurrent = reverseHead;
            
            while(current != null){
                if(current.val != reverseCurrent.val){
                    return false;
                }
                
                current = current.next;
                reverseCurrent = reverseCurrent.next;
            }
            
            return true;
        } 
    }
}