public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> list = new List<IList<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        TreeNode node;
        
        if(root == null){
            return list;
        }
        
        queue.Enqueue(root);
        
        while(queue.Count > 0){
            List<int> subList = new List<int>();
            int count = queue.Count;
            
            while(count > 0){
                node = queue.Dequeue();
                subList.Add(node.val);
                if(node.left != null){
                    queue.Enqueue(node.left);
                }
                if(node.right != null){
                    queue.Enqueue(node.right);
                }
                count--;
            }
            
            list.Add(subList);
        }
        
        return list;
    }
}