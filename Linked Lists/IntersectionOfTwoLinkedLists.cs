/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        if(headA == null || headB == null){
            return null;
        }
        
        int lengthA = 0;
        int lengthB = 0;
        ListNode startA = headA;
        ListNode startB = headB;
        
        while(startA != null){
            lengthA++;
            startA = startA.next;
        }
        
        while(startB != null){
            lengthB++;
            startB = startB.next;
        }
        
        while(lengthA > lengthB) {
            headA = headA.next;
            lengthA--;
        }
        
        while(lengthB > lengthA) {
            headB = headB.next;
            lengthB--;
        }
        
        ListNode intersect = null;
        
        while(headA != null && headB != null && headA != headB){
            headA = headA.next;
            headB = headB.next;
        }
        
        if(headA == headB){
            intersect = headA;
        }
        
        return intersect;
    }
}