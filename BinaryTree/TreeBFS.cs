using System.Collections.Generic;
namespace Traversal
{
    class TreeBFS
    {
        public static TreeNode root = TreeInit.Init();
        private static List<int> result;

        public static List<int> BFS()
        {
            result = new List<int>();
            Traversal(root);
            return result;
        }
        private static void Traversal(TreeNode node)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                TreeNode curr = queue.Dequeue();
                result.Add(curr.val);
                if (curr.left != null)
                    queue.Enqueue(curr.left);
                if (curr.right != null)
                    queue.Enqueue(curr.right);
            }
        }
    }
}