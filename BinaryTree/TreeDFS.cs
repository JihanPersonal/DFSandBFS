using System;
using System.Collections.Generic;
namespace Traversal
{
    class TreeDFS
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
            if (node != null)
            {
                result.Add(node.val);
                if (node.left != null)
                {
                    TraversalPreoder(node.left);
                }
                if (node.right != null)
                {
                    TraversalPreoder(node.right);
                }
            }
        }

        private static void TraversalInoder(TreeNode node)
        {
            if (node != null)
            {
                if (node.left != null)
                {
                    TraversalInoder(node.left);
                }
                result.Add(node.val);
                if (node.right != null)
                {
                    TraversalInoder(node.right);
                }
            }
        }

        private static void TraversalPostoder(TreeNode node)
        {
            if (node != null)
            {
                if (node.left != null)
                {
                    TraversalPostoder(node.left);
                }
                if (node.right != null)
                {
                    TraversalPostoder(node.right);
                }
                result.Add(node.val);
            }
        }
    }
}
