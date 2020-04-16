using System;
using System.Collections.Generic;
namespace Traversal
{
    class TreeDFSV2
    {
        public static TreeNode root = TreeInit.Init();
        private static List<int> result;
        public static List<int> DFS()
        {
            result = new List<int>();
            //TraversalPreoder(root);
            //TraversalInoder(root);
            TraversalPostoder(root);
            return result;
        }

        private static void TraversalPreoder(TreeNode node)
        {
            Stack<TreeNode> temp = new Stack<TreeNode>();
            TreeNode curr = node;
            while (temp.Count > 0 || curr != null)
            {
                while (curr != null)
                {
                    temp.Push(curr);
                    result.Add(curr.val);
                    curr = curr.left;
                }
                curr = temp.Pop();
                curr = curr.right;
            }
        }

        private static void TraversalInoder(TreeNode node)
        {
            Stack<TreeNode> temp = new Stack<TreeNode>();
            TreeNode curr = node;
            while (temp.Count > 0 || curr != null)
            {
                while (curr != null)
                {
                    temp.Push(curr);
                    curr = curr.left;
                }
                curr = temp.Pop();
                result.Add(curr.val);
                curr = curr.right;
            }
        }

        private static void TraversalPostoder(TreeNode node)
        {
            Stack<TreeNode> temp = new Stack<TreeNode>();
            TreeNode curr = node;
            while (temp.Count > 0 || curr != null)
            {
                while (curr != null)
                {
                    temp.Push(curr);
                    temp.Push(curr);
                    curr = curr.left;
                }
                curr = temp.Pop();
                if (temp.Count > 0 && curr == temp.Peek()) curr = curr.right;
                else
                {
                    result.Add(curr.val);
                    curr = null;
                }
            }
        }
    }
}
