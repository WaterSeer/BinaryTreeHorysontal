using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    interface INode
    {
        INode Left { get; }
        INode Right { get; }
        int Value { get; }
    }
}
