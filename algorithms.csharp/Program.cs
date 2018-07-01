using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using algorithms.csharp.dijkstra;
using algorithms.csharp.common.Utility;

namespace Algorithms.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Edge> edges = new List<Edge> { new Edge(0,1,10), new Edge(0,4,3),
                new Edge(1,2,2), new Edge(1,4,4),
                new Edge(2,3,9), new Edge(3,2,7),
                new Edge(4,1,1), new Edge(4,2,8),
                new Edge(4,3,2)
            };

            const int N = 5;
            Graph graph = new Graph(edges, N);

            // get shortest paths from Node 0 to other nodes
            DijkstraSample1.ShortestPath(graph, 0, N);


        }
    }
}
