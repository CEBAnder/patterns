using System.Collections.Generic;

namespace Patterns.Iterator
{
    public class NodeWithChildren : TreeNode
    {
        private readonly List<TreeNode> _childNodes;

        public NodeWithChildren(int value, List<TreeNode> children, bool hasChildren = true) : base(value, hasChildren)
        {
            _childNodes = children;
        }

        public override List<TreeNode> GetChildren()
        {
            return _childNodes;
        }
    }
}
