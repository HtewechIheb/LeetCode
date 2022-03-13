public class Solution {
    public int FindNumbers(int[] nums) {
        short numEvenDigits = 0;
        byte numDigits;
        int divider;
        int currNum;
        
        for(var i = 0; i < nums.Length; i++){
            numDigits = 1;
            divider = 10;
            currNum = nums[i];
            
            while((currNum / divider) != 0){
                numDigits++;
                divider *= 10;
            }
            
            if(numDigits % 2 == 0){
                numEvenDigits++;
            }
        }
        
        return numEvenDigits;
    }
}