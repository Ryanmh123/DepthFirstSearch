using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthFirstSearch
{
    public class DFSGraph
    {
        private int NumVertices;
        private List<int>[] Adj; //adjacency list; array of List<int>

        public DFSGraph(int numVertices)
        {
            NumVertices = numVertices;
            Adj = new List<int>[numVertices];

            for (int i = 0; i < numVertices; i++)
            {
                Adj[i] = new List<int>();
            }
        }
        public static DFSGraph MakeSampleGraph()
        {
            DFSGraph G = new DFSGraph(4);
            G.AddEdge(0, 1);
            G.AddEdge(0, 2);
            G.AddEdge(1, 2);
            G.AddEdge(2, 0);
            G.AddEdge(2, 3);
            G.AddEdge(3, 2);

            return G;
        }

        public void AddEdge(int v, int w)
        {
            Adj[v].Add(w);
        }

        public void RecursiveDFS(int vertex)
        {
            bool[] visited = new bool[NumVertices];
            RecursiveDFSUtil(vertex, visited);
        }

        //vertex parameter designates beginning vertex
        private void RecursiveDFSUtil(int vertex, bool[] visited)
        {
            visited[vertex] = true;
            Console.Write(vertex + " ");

            foreach (int i in Adj[vertex])
            {
                if (!visited[i])
                {
                    RecursiveDFSUtil(i, visited);
                }
            }
        }

        public void IterativeDFS(int v)
        {
            bool[] visited = new bool[NumVertices];
            Stack<int> stack = new Stack<int>();
            stack.Push(v);

            while (stack.Count != 0)
            {
                v = stack.Pop();

                if (!visited[v])
                {
                    visited[v] = true;
                    Console.Write(v + " ");

                    foreach (int i in Adj[v])
                    {
                        if (!visited[i])
                        {
                            stack.Push(i);
                        }
                    }
                }
            }
        }

        /*
        The order in which the vertices are printed during a DFS traversal (whether recursive or iterative) depends on the 
        order in which the vertices are processed by the algorithm. In general, the order of processing depends on the data 
        structure used to keep track of the vertices that need to be visited.

        In the case of the recursive method, the order of processing is determined by the order in which the recursive 
        calls are made. The recursive method visits each adjacent vertex in the order in which they appear in the adjacency list 
        for the current vertex. Since the adjacency list for vertex 2 has vertices 0 and 3 in that order, the DFS traversal 
        visits vertex 0 before vertex 3, resulting in the output "2 0 1 3".

        In the case of the iterative method, the order of processing is determined by the order in which vertices are 
        popped off the stack. The DFS traversal starts at vertex 2 and pushes its adjacent vertices 3 and 0 onto the stack in
        that order. The DFS algorithm then pops vertex 0 off the stack and pushes its adjacent vertex 1 onto the stack. The DFS
        algorithm then pops vertex 1 off the stack and continues with vertex 3. The order of processing in the iterative DFS 
        algorithm is therefore "2 3 0 1".
        */

    }//end of class
}
