/*** Recursive ***/

public class Solution {
    private void TraverseTree(TreeNode root, List<int> list){
        if(root != null){
            TraverseTree(root.left, list);
            list.Add(root.val);
            TraverseTree(root.right, list);
        }
    }
    
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> list = new List<int>();
        TraverseTree(root, list);
        return list;
    }
}

/*** Iterative ***/

public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        List<int> list = new List<int>();
        TreeNode current = root;
        
        while(current != null || stack.Count > 0){
            while(current != null){
                stack.Push(current);
                current = current.left;
            }
            
            current = stack.Pop();
            list.Add(current.val);
            current = current.right;
        }
        
        return list;
    }
}