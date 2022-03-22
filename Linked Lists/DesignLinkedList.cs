/*** Singly ***/

public class MyLinkedList {
    class MyLinkedListNode {
        public int val;
        public MyLinkedListNode next;
    }
    
    MyLinkedListNode head;

    public MyLinkedList() {
        head = null;
    }
    
    public int Get(int index) {
        MyLinkedListNode current = head;
        
        for(int i = 1; i <= index && current != null; i++){
            current = current.next;
        }
        
        if(current != null){
            return current.val;
        }
        else {
            return -1;
        }
    }
    
    public void AddAtHead(int val) {
        MyLinkedListNode node = new MyLinkedListNode();
        node.val = val;
        node.next = head;
        
        head = node;
    }
    
    public void AddAtTail(int val) {
        MyLinkedListNode node = new MyLinkedListNode();
        node.val = val;
        
        if(head == null) {
            head = node;
        }
        else {
            MyLinkedListNode current = head;
        
            while(current.next != null){
                current = current.next;
            }

            current.next = node;
        }
    }
    
    public void AddAtIndex(int index, int val) {
        MyLinkedListNode node = new MyLinkedListNode();
        node.val = val;
        
        if(index == 0){
            AddAtHead(val);
        }
        else {
            MyLinkedListNode current = head;
        
            for(int i = 1; i <= index - 1 && current != null; i++){
                current = current.next;
            }

            if(current != null){
                node.next = current.next;
                current.next = node;
            } 
        }
    }
    
    public void DeleteAtIndex(int index) {
        MyLinkedListNode current = head;
        
        if(index == 0){
            head = head.next;
        }
        else {
            for(int i = 1; i <= index - 1 && current != null; i++){
                current = current.next;
            }

            if(current != null && current.next != null){
                current.next = current.next.next;
            }
        }
    }
}

/*** Doubly ***/

public class MyLinkedList {
    class MyLinkedListNode {
        public int val;
        public MyLinkedListNode next;
        public MyLinkedListNode prev;
    }
    
    MyLinkedListNode head;

    public MyLinkedList() {
        head = null;
    }
    
    public int Get(int index) {
        MyLinkedListNode current = head;
        
        for(int i = 1; i <= index && current != null; i++){
            current = current.next;
        }
        
        if(current != null){
            return current.val;
        }
        else {
            return -1;
        }
    }
    
    public void AddAtHead(int val) {
        MyLinkedListNode node = new MyLinkedListNode();
        node.val = val;
        node.next = head;
        
        if(head != null){
            head.prev = node;
        }
        head = node;
    }
    
    public void AddAtTail(int val) {
        MyLinkedListNode node = new MyLinkedListNode();
        node.val = val;
        
        if(head == null) {
            head = node;
        }
        else {
            MyLinkedListNode current = head;
        
            while(current.next != null){
                current = current.next;
            }

            node.prev = current;
            current.next = node;
        }
    }
    
    public void AddAtIndex(int index, int val) {
        MyLinkedListNode node = new MyLinkedListNode();
        node.val = val;
        
        if(index == 0){
            AddAtHead(val);
        }
        else {
            MyLinkedListNode current = head;
        
            for(int i = 1; i <= index - 1 && current != null; i++){
                current = current.next;
            }

            if(current != null){
                node.next = current.next;
                node.prev = current;
                
                node.prev.next = node;
                if(node.next != null){
                    node.next.prev = node;
                }
            } 
        }
    }
    
    public void DeleteAtIndex(int index) {
        MyLinkedListNode current = head;
        
        if(index == 0){
            head = head.next;
            
            if(head != null){
                head.prev = null;
            }
        }
        else {
            for(int i = 1; i <= index - 1 && current != null; i++){
                current = current.next;
            }

            if(current != null && current.next != null){
                current.next = current.next.next;
                
                if(current.next != null){
                    current.next.prev = current;
                }
            }
        }
    }
}