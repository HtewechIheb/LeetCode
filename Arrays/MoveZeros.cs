public class Solution {
    public void MoveZeroes(int[] nums) {
        if(nums == null || nums.Length == 0){
            return;
        }
        
        int ptr = 0;
        int zeroPtr = 0;
        
        while(ptr < nums.Length && zeroPtr < nums.Length) {
            if(nums[ptr] == 0){
                while(zeroPtr < nums.Length && (zeroPtr <= ptr || nums[zeroPtr] == 0)){
                    zeroPtr++;
                }
                
                if(zeroPtr < nums.Length){
                    int aux = nums[ptr];
                    nums[ptr] = nums[zeroPtr];
                    nums[zeroPtr] = aux;
                }
            }
            
            ptr++;
        }
    }
}