public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int ones = 0;
        int maxOnes = 0;
        foreach(var num in nums){
            if(num == 1){
                ones++;
            }
            else {
                if(ones > maxOnes){
                    maxOnes = ones;
                }
                ones = 0;
            }
        }
        if(ones > maxOnes){
            maxOnes = ones;
        }
        return maxOnes;
    }
}