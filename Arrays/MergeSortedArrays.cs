public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] temp = new int[nums1.Length];
        int index1 = 0;
        int index2 = 0;
        int indexTemp = 0;
        
        while(index1 < m && index2 < n){
            if(nums1[index1] <= nums2[index2]){
                temp[indexTemp] = nums1[index1];
                index1++;
            }
            else{
                temp[indexTemp] = nums2[index2];
                index2++;
            }
            indexTemp++;
        }
        
        while(index1 < m){
            temp[indexTemp] = nums1[index1];
            index1++;
            indexTemp++;
        }
        
        while(index2 < n){
            temp[indexTemp] = nums2[index2];
            index2++;
            indexTemp++;
        }
        
        temp.CopyTo(nums1, 0);
    }
}