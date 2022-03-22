public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        List<int> disappearedNumbers = new List<int>();
        bool[] indexes = new bool[nums.Length];
        
        for(int i = 0; i < nums.Length; i++){
            indexes[i] = false;
        }
        
        for(int i = 0; i < nums.Length; i++){
            indexes[nums[i] - 1] = true;
        }
        
        for(int i = 0; i < nums.Length; i++){
            if(!indexes[i]) {
                disappearedNumbers.Add(i + 1);
            }
        }
        
        return disappearedNumbers;
    }
}