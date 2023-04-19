using System;

namespace DepthFirstSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Using DFS on a binary tree
            Node tree = DFSTree.MakeSampleTree();

            //Console.WriteLine("Binary Tree\nDFS using Recursion:");
            //DFSTree.RecursiveDFS(tree);

            //Console.WriteLine("\n\nDFS using Iteration:");
            //DFSTree.IterativeDFS(tree);

            //Using DFS on a graph
            DFSGraph G = DFSGraph.MakeSampleGraph();

            Console.WriteLine("\n\nGraph\nDFS Using Recursion:");
            G.RecursiveDFS(2); //change to 2 for demonstration

            Console.WriteLine("\n\nDFS using Iteration:");
            G.IterativeDFS(2); //change to 2 for demonstration

        }
    }
}