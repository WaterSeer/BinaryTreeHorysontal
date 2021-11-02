using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node : INode
    {
        private int _value;
        private INode _left;
        private INode _right;

        public Node(INode node)
        {
            _value = node.Value;
            _left = node.Left;
            _right = node.Right;
        }

        public Node(int value, Node left, Node right)
        {
            _value = value;
            _left = left;
            _right = right;
        }

        public INode Left => _left;
        public INode Right => _right;
        public int Value => _value;
    }
}
