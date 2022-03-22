public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode();
        ListNode result = dummy;
        
        int carry = 0;
        int sum;
        
        while(l1 != null || l2 != null || carry != 0){
            sum = carry;
            
            if(l1 != null){
                sum += l1.val;
                l1 = l1.next;
            }
            if(l2 != null){
                sum += l2.val;
                l2 = l2.next;
            }
            
            carry = sum / 10;
            sum = sum % 10;
            
            result.next = new ListNode(sum);
            result = result.next;
        }
        
        return dummy.next;
    }
}