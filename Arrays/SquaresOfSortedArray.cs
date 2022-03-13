public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] sortedSquares = new int[nums.Length];
        short sortedSquaresIndex = 0;
        short firstPositiveIndex = 0;
        
        for(short i = 0; i < nums.Length; i++){
            if(nums[i] < 0){
                firstPositiveIndex++;
            }
            nums[i] = nums[i] * nums[i];
        }
        
        short positivesIndex = firstPositiveIndex;
        short negativesIndex = (short)(firstPositiveIndex - 1);
        
        while(positivesIndex < nums.Length && negativesIndex >= 0){
            if(nums[positivesIndex] <= nums[negativesIndex]){
                sortedSquares[sortedSquaresIndex] = nums[positivesIndex];
                positivesIndex++;
            }
            else {
                sortedSquares[sortedSquaresIndex] = nums[negativesIndex];
                negativesIndex--;
            }
            sortedSquaresIndex++;
        }
        
        if(positivesIndex < nums.Length){
            while(positivesIndex < nums.Length){
                sortedSquares[sortedSquaresIndex] = nums[positivesIndex];
                sortedSquaresIndex++;
                positivesIndex++;
            }
        }
        
        if(negativesIndex >= 0){
            while(negativesIndex >= 0){
                sortedSquares[sortedSquaresIndex] = nums[negativesIndex];
                sortedSquaresIndex++;
                negativesIndex--;
            }
        }
        
        return sortedSquares;
    }
}