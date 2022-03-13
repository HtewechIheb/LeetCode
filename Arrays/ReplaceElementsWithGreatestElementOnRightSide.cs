public class Solution {
    public int[] ReplaceElements(int[] arr) {
        if(arr == null || arr.Length == 0){
            return arr;
        }
        
        for(int i = 0; i < arr.Length - 1; i++){
            arr[i] = arr[i + 1];

            for(int j = i + 2; j < arr.Length; j++){
                if(arr[j] > arr[i]){
                    arr[i] = arr[j];
                }
            }
        }

        arr[arr.Length - 1] = -1;
        return arr;
    }
}