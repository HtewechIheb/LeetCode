public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        if(nums == null || nums.Length == 0){
            return nums;
        }
        
        int evenPtr = 0;
        int aux;
        
        for(int oddPtr = 0; oddPtr < nums.Length; oddPtr++){
            if(nums[oddPtr] % 2 == 0){
                aux = nums[oddPtr];
                nums[oddPtr] = nums[evenPtr];
                nums[evenPtr++] = aux;
            }
        }
        
        return nums;
    }
}