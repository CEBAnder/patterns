using System.Collections;
using System.Collections.Generic;

namespace Patterns.Iterator
{
    public class TreeNode : IEnumerable<TreeNode>
    {
        public int NodeValue;

        public List<TreeNode> ChildNodes;

        public TreeNode(int value)
        {
            NodeValue = value;
            ChildNodes = new List<TreeNode>();
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
