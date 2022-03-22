public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode mergedList = new ListNode();
        ListNode mergedListPtr = mergedList;
        
        while(list1 != null && list2 != null){
            if(list1.val <= list2.val){
                mergedListPtr.next = list1;
                mergedListPtr = mergedListPtr.next;
                list1 = list1.next;
            }  
            else {
                mergedListPtr.next = list2;
                mergedListPtr = mergedListPtr.next;
                list2 = list2.next;
            }
        }
        
        if(list1 == null) {
            mergedListPtr.next = list2;
        }
        if (list2 == null){
            mergedListPtr.next = list1;
        }
        
        return mergedList.next;
    }
}