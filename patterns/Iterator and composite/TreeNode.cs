using System;
using System.Collections;
using System.Collections.Generic;

namespace Patterns.Iterator
{
    public class TreeNode : IEnumerable<TreeNode>
    {
        public readonly int NodeValue;

        public readonly bool HasChildren;

        public virtual List<TreeNode> GetChildren()
        {
            throw new Exception();
        }

        public TreeNode(int value, bool hasChildren = false)
        {
            NodeValue = value;
            HasChildren = hasChildren;
        }

        public IEnumerator<TreeNode> GetEnumerator()
        {
            return BreadthFirstEnumerator.Create(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return BreadthFirstEnumerator.Create(this);
        }
    }
}
