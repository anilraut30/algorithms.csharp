using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms.csharp.common.Utility
{
    public class Edge
    {
        //int source, dest, weight;
        public int source { get; set; }
        public int dest { get; set; }
        public int weight { get; set; }
        public Edge(int s, int d, int w)
        {
            this.source = s;
            this.dest = d;
            this.weight = w;
        }
    }

    public class Graph
    {

        public Dictionary<int, List<Edge>> adjList { get; set; }
        public Graph(List<Edge> edges, int N)
        {
            adjList = new Dictionary<int, List<Edge>>();
            for (int i = 0; i < N; i++)
            {
                adjList.Add(i, new List<Edge>());
            }

            foreach (Edge ed in edges)
            {
                adjList[ed.source].Add(ed);
            }

        }
    }

    // Node
    public class Node : IComparable<Node>
    {

        public Node(int v, int weight)
        {
            Vertex = v;
            Weight = weight;
        }

        public int Vertex { get; set; }
        public int Weight { get; set; }
        public int CompareTo(Node other)
        {
            // throw new NotImplementedException();
            if (Weight < other.Weight) return -1;
            else if (Weight > other.Weight) return 1;
            else return 0;
        }
    }

}
