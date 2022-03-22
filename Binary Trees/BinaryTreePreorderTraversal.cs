/*** Recursive ***/

public class Solution {
    private void TraverseTree(TreeNode root, List<int> list){
        if(root != null){
            list.Add(root.val);
            TraverseTree(root.left, list);
            TraverseTree(root.right, list);
        }
    }
    
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> list = new List<int>();
        TraverseTree(root, list);
        return list;
    }
}

/*** Iterative ***/

public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        List<int> list = new List<int>();
        TreeNode current;
        
        if(root == null){
            return list;
        }
        
        stack.Push(root);
        
        while(stack.Count > 0){
            current = stack.Pop();
            
            list.Add(current.val);
            if(current.right != null){
                stack.Push(current.right);
            }
            if(current.left != null){
                stack.Push(current.left);
            }
        }
        
        return list;
    }
}