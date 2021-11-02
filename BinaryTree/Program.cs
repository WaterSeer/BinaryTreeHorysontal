using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Node> nodes = FillNodeList();
            PrintNodeLevelReverse(nodes[6]);
            Console.ReadLine();
        }

        public static List<Node> FillNodeList()
        {
            List<Node> nodeList = new List<Node>();
            nodeList.Add(new Node(2, null, null));
            nodeList.Add(new Node(6, null, null));
            nodeList.Add(new Node(24, null, null));
            nodeList.Add(new Node(15, null, nodeList[2]));
            nodeList.Add(new Node(5, nodeList[0], nodeList[1]));
            nodeList.Add(new Node(12, null, nodeList[3]));
            nodeList.Add(new Node(8, nodeList[4], nodeList[5]));    //root node
            return nodeList;
        }        
        
        public static void PrintNodeLevelReverse(INode node)
        {            
            List<List<int>> valueOnLevels = new List<List<int>>();
            List<int> nodesOnLevel = new List<int>();
            Queue<INode> enQueue = new Queue<INode>();
            Queue<INode> deQueue = new Queue<INode>();
            Queue<INode> split;
            INode top = node;
            deQueue.Enqueue(top);
            int level = 1;
            do
            {                
                if (deQueue.Count != 0)
                {
                    
                    top = deQueue.Dequeue();                    
                    nodesOnLevel.Add(top.Value);
                    if (top.Left != null) enQueue.Enqueue(top.Left);
                    if (top.Right != null) enQueue.Enqueue(top.Right);
                }
                else
                {
                    split = deQueue;
                    deQueue = enQueue;
                    enQueue = split;
                    enQueue.Clear();
                    valueOnLevels.Add(nodesOnLevel);
                    nodesOnLevel = new List<int>();
                    level++;                    
                }
            } while (enQueue.Count != 0 || deQueue.Count != 0);
            valueOnLevels.Add(nodesOnLevel);
            for (int i = level; i >= 1; i--)            
            {
                Console.WriteLine("Level " + i.ToString() + ": " + string.Join(", ", valueOnLevels[i-1]));
            }
        }
    }
}
