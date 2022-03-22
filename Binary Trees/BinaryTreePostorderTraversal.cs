/*** Recursive ***/

public class Solution {
    private void TraverseTree(TreeNode root, List<int> list){
        if(root != null){
            TraverseTree(root.left, list);
            TraverseTree(root.right, list);
            list.Add(root.val);
        }
    }
    
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> list = new List<int>();
        TraverseTree(root, list);
        return list;
    }
}

/*** Iterative ***/

public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        List<int> list = new List<int>();
        TreeNode lastVisited = null;
        
        if(root == null){
            return list;
        }
        
        while(root != null || stack.Count > 0){
            while(root != null){
                stack.Push(root);
                root = root.left;
            }
            
            root = stack.Peek();
            if(root.right == null || root.right == lastVisited){
                stack.Pop();
                list.Add(root.val);
                lastVisited = root;
                root = null;
            }
            else {
                root = root.right;   
            }
        }
        
        return list;
    }
}
