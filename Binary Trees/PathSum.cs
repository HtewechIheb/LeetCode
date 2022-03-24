public class Solution {
    public bool HasPathSum(TreeNode root, int targetSum) {
        if(root == null) return false;
        
        if(root.right == null && root.left == null) return targetSum == root.val;
        
        return HasPathSum(root.right, targetSum - root.val) || HasPathSum(root.left, targetSum - root.val);
    }
}