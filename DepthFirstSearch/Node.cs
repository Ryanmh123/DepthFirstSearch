using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthFirstSearch
{
    public class Node
    {
        public Node? Left { get; set; }
        public Node? Right { get; set; }
        public int Data { get; set; }

        public Node(int data, Node left, Node right) 
        {
            Data = data;
            Left = left; 
            Right = right;
        }

        public Node(int data) 
        { 
            Data = data;
        }
    }
}
