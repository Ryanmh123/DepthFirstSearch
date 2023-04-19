using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthFirstSearch
{
    public class DFSTree //DFS works on the premise of LIFO, so it uses stacks, not queues
                         //Using preorder traversal--I did not explore inorder or postorder
    {
        public static Node MakeSampleTree()
        {
                               //Data, Left, Right
            Node root = new Node(7, new Node(5), new Node(4));
                        
            root.Left.Left = new Node(8);
            root.Left.Right = new Node(3);
            root.Left.Right.Left = new Node(6);

            root.Right.Left = new Node(9);

            return root;
        }

        public static void RecursiveDFS(Node node)
        {
            //base condition
            if (node == null)
                return;

            Console.Write(node.Data + " ");
            RecursiveDFS(node.Left);
            RecursiveDFS(node.Right);
        }

        public static void IterativeDFS(Node node)
        {
            if (node == null)
                return;

            Stack<Node> stack = new Stack<Node>();
            stack.Push(node);

            while (stack.Count > 0)
            {
                Node current = stack.Pop();
                Console.Write(current.Data + " ");

                if (current.Right != null)
                {
                    stack.Push(current.Right);
                }

                if (current.Left != null)
                {
                    stack.Push(current.Left);
                }
            }
        }
    }//end of class
}
