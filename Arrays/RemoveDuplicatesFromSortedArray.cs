public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int currentNumberIndex = 0;
        
        for(int i = 1; i < nums.Length; i++){
            if(nums[currentNumberIndex] != nums[i]){
                currentNumberIndex++;
                nums[currentNumberIndex] = nums[i];
            }
        }
        
        return currentNumberIndex + 1;
    }
}