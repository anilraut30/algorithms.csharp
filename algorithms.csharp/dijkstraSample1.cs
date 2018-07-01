using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using algorithms.csharp.common.DataStructure;
using algorithms.csharp.common.Utility;

namespace algorithms.csharp.dijkstra
{
    public class DijkstraSample1
    {
        private static void printRoute(int[] prev, int i)
        {
            if (i < 0)
                return;
            printRoute(prev, prev[i]);

            Console.Write(i + " ");

        }

        public static void ShortestPath(Graph graph, int source, int N)
        {
            // create min Heap and push source node having distance 0;

            PriorityQueue<Node> pq = new PriorityQueue<Node>();

            pq.Enqueue(new Node(source, 0));

            List<int> dist = new List<int>();

            for (int i = 0; i < N; i++)
            {
                dist.Add(int.MaxValue);
            }

            // Set dist from source to itself 0
            dist[source] = 0;

            bool[] done = new bool[N];
            done[source] = true;

            // store predesesor of of vertext (to print path)
            int[] prev = new int[N];
            prev[source] = -1;

            while (pq.Count > 0)
            {
                Node node = pq.Dequeue();

                // get vertex number
                int u = node.Vertex;

                // do for each neighbour v of u
                foreach (Edge edge in graph.adjList[u])
                {
                    int destVertex = edge.dest;
                    int weight = edge.weight;
                    int destVertextNewWt = dist[u] + weight;
                    // relaxation step
                    if (!done[destVertex] && destVertextNewWt < dist[destVertex])
                    {
                        dist[destVertex] = destVertextNewWt;
                        prev[destVertex] = u;
                        pq.Enqueue(new Node(destVertex, destVertextNewWt));

                    }

                }
                // mark the vertext u as done
                done[u] = true;
            }

            for (int i = 1; i < N; i++)
            {
                Console.Write($"Path from 0 to vertex {i} has min cost of {dist[i]} and the route is [");

                printRoute(prev, i);
                Console.WriteLine("]");

            }
            Console.ReadKey();

        }

    }

}
