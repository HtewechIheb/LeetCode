public class Solution {
    public bool ValidMountainArray(int[] arr) {
        if(arr.Length < 3){
            return false;
        }
        
        int maxIndex = 0;
        int increasingNumbers = 0;
        int decreasingNumbers = 0;
        
        for(int i = 1; i < arr.Length; i++){
            if(arr[i] > arr[maxIndex]){
                maxIndex = i;
            }
        }
        
        int j = maxIndex;
        int k = maxIndex;
        
        while(j < arr.Length - 1){
            if(arr[j] <= arr[j + 1]){
                return false;
            }
            
            j++;
            decreasingNumbers++;
        }
        
        while(k > 0){
            if(arr[k] <= arr[k - 1]){
                return false;
            }
            
            k--;
            increasingNumbers++;
        }
        
        return increasingNumbers > 0 && decreasingNumbers > 0;
    }
}