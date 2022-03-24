public class Solution {
    private void SymmetricInorderTraversal(TreeNode leftRoot, TreeNode rightRoot, ref bool symmetric){
        if(leftRoot != null && rightRoot != null){
            SymmetricInorderTraversal(leftRoot.left, rightRoot.right, ref symmetric);
            if(leftRoot.val != rightRoot.val){
                symmetric = false;
            }
            SymmetricInorderTraversal(leftRoot.right, rightRoot.left, ref symmetric);
        }
        else if(leftRoot != null || rightRoot != null){
            symmetric = false;
        }
    }
    
    public bool IsSymmetric(TreeNode root) {
        bool symmetric = true;
        SymmetricInorderTraversal(root.left, root.right, ref symmetric);
        return symmetric;
    }
}

/*** Cleaner Solution ***/

public class Solution {
    private bool SymmetricInorderTraversal(TreeNode leftRoot, TreeNode rightRoot){
        if(leftRoot == null && rightRoot == null) return true;

        if(leftRoot == null || rightRoot == null) return false;

        return SymmetricInorderTraversal(leftRoot.left, rightRoot.right) && leftRoot.val == rightRoot.val &&  SymmetricInorderTraversal(leftRoot.right, rightRoot.left);
    }
    
    public bool IsSymmetric(TreeNode root) {
        return SymmetricInorderTraversal(root.left, root.right);
    }
}