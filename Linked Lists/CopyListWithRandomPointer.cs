public class Solution {
    public Node CopyRandomList(Node head) {
        if(head == null){
            return null;
        }
        
        Node dummy = new Node(0);
        Node copyCurrent = dummy;
        Node current = head;
        
        Dictionary<Node, Node> nodes = new Dictionary<Node, Node>();
        
        while(current != null){
            if(!nodes.ContainsKey(current)){
                Node node = new Node(current.val);
                copyCurrent.next = node;
                
                nodes.Add(current, node);
            }
            else {
                copyCurrent.next = nodes[current];
            }
            
            copyCurrent = copyCurrent.next;
            
            if(current.random != null){
                if(!nodes.ContainsKey(current.random)){
                    Node node = new Node(current.random.val);
                    copyCurrent.random = node;
                    
                    nodes.Add(current.random, node);
                }
                else {
                    copyCurrent.random = nodes[current.random];
                }
            }
            else {
                copyCurrent.random = null;
            }
            
            current = current.next;
        }
        
        return dummy.next;
    }
}