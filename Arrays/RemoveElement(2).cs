public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if(nums == null || nums.Length == 0){
            return 0;
        }
        
        int nonValPtr = 0;
        int aux;
        
        for(int valPtr = 0; valPtr < nums.Length; valPtr++){
            if(nums[valPtr] != val){
                nums[nonValPtr++] = nums[valPtr];
            }
        }
        
        return nonValPtr;
    }
}