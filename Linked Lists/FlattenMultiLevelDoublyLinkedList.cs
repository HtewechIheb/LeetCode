public class Solution {
    public Node Flatten(Node head, Node parentNext = null) {
        if(head == null){
            return null;
        }
        
        Node current = head;
        Node tail = current;
        
        while(current != null){
            if(current.child != null){
                Node child = Flatten(current.child, current.next);
                
                current.next = child;
                child.prev = current;
                current.child = null;
            }
            
            if(current.next == null){
                tail = current;
            }
            current = current.next;
        }
        
        if(parentNext != null){
            tail.next = parentNext;
            parentNext.prev = tail;
        }
        
        return head;
    }
}