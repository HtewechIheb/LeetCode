public class Solution {
    public int ThirdMax(int[] nums) {
        int firstMax = nums[0];
        
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] > firstMax){
                firstMax = nums[i];
            }
        }
        
        if(nums.Length < 3){
            return firstMax;
        }
        
        int secondMax = firstMax;
        
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] < firstMax){
                secondMax = nums[i];
            }
        }
        
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] > secondMax && nums[i] < firstMax){
                secondMax = nums[i];
            }
        }
        
        if(secondMax == firstMax){
            return firstMax;
        }
        
        int thirdMax = secondMax;
        
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] < firstMax && nums[i] < secondMax){
                thirdMax = nums[i];
            }
        }
        
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] > thirdMax && nums[i] < secondMax){
                thirdMax = nums[i];
            }
        }
        
        if(thirdMax == secondMax){
            return firstMax;
        }
        
        return thirdMax;
    }
}