using Patterns.Iterator;
using System;
using System.Collections.Generic;

namespace UseCases
{
    public class Iterator
    {
        public static void IterateTree()
        {
            var tree = CreateTree();

            foreach(var node in tree)
            {
                Console.WriteLine(node.NodeValue);
            }
        }

        private static TreeNode CreateTree()
        {
            var node5 = new TreeNode(5);
            var node6 = new TreeNode(6);
            var node7 = new TreeNode(7);
            var node8 = new TreeNode(8);
            var node9 = new TreeNode(9);
            var node10 = new TreeNode(10);
            var node4 = new NodeWithChildren(4, new List<TreeNode> { node8, node9, node10 });
            var node3 = new NodeWithChildren(3, new List<TreeNode> { node6, node7 });
            var node2 = new NodeWithChildren(2, new List <TreeNode> { node4, node5 });
            var node1 = new NodeWithChildren(1, new List <TreeNode> { node2, node3 });

            return node1;
        }
    }
}
