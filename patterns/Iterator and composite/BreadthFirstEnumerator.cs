using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.Iterator
{
    public class BreadthFirstEnumerator : IEnumerator<TreeNode>
    {
        private TreeNode _mainNode;

        private List<TreeNode> _visitedNodes = new List<TreeNode>();

        private List<TreeNode> _notVisitedNodes = new List<TreeNode>();

        private BreadthFirstEnumerator(TreeNode mainNode)
        {
            _mainNode = mainNode;

            _notVisitedNodes.Add(mainNode);
        }

        public static BreadthFirstEnumerator Create(TreeNode mainNode)
        {
            return new BreadthFirstEnumerator(mainNode);
        }

        public TreeNode Current
        {
            get
            {
                var current = _notVisitedNodes.First();

                _visitedNodes.Add(current);

                if (current.HasChildren)
                {
                    _notVisitedNodes.AddRange(current.GetChildren());
                }

                _notVisitedNodes.Remove(current);

                return current;
            }
        }
        

        object IEnumerator.Current => _notVisitedNodes.First();

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (!_notVisitedNodes.Any())
                return false;

            return true;
        }

        public void Reset()
        {
            Create(_mainNode);
        }
    }
}
