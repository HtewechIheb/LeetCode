public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if(nums.Length == 0){
            return 0;
        }
        
        int backCounter = nums.Length - 1;
        
        for(int i = 0; i < nums.Length && backCounter > i; i++){
            if(nums[i] == val){
                while(backCounter > i && nums[backCounter] == val){
                    backCounter--;
                }
                
                nums[i] = nums[backCounter];
                nums[backCounter] = val;
            }
        }
        
        return nums[backCounter] == val ? backCounter : backCounter + 1;
    }
}