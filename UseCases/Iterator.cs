using Patterns.Iterator;
using System;

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
            var node1 = new TreeNode(1);
            var node2 = new TreeNode(2);
            var node3 = new TreeNode(3);
            var node4 = new TreeNode(4);
            var node5 = new TreeNode(5);
            var node6 = new TreeNode(6);
            var node7 = new TreeNode(7);
            var node8 = new TreeNode(8);
            var node9 = new TreeNode(9);
            var node10 = new TreeNode(10);

            node1.ChildNodes.Add(node2);
            node1.ChildNodes.Add(node3);
            node2.ChildNodes.Add(node4);
            node2.ChildNodes.Add(node5);
            node3.ChildNodes.Add(node6);
            node3.ChildNodes.Add(node7);
            node4.ChildNodes.Add(node8);
            node4.ChildNodes.Add(node9);
            node4.ChildNodes.Add(node10);

            return node1;
        }
    }
}
