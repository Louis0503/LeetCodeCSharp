using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetCode.Graph
{
    public class Clone_Graph
    {

        public class UndirectedGraphNode
        {   
            public int label;
            public IList<UndirectedGraphNode> neighbors;
            public UndirectedGraphNode(int x)
            {
                label = x;
                neighbors = new List<UndirectedGraphNode>();
            }
        };

        public UndirectedGraphNode CloneGraph(UndirectedGraphNode node)
        {
            if(node == null) {
                return null;
            }
            var mapping = new Dictionary<UndirectedGraphNode, UndirectedGraphNode>();
            // 1. get all vertices
            var nodes = GetAllNodes(node);
            // 2. copy all vertices
            foreach(var vertex in nodes) {
                mapping.Add(vertex, new UndirectedGraphNode(vertex.label));
            }
            // 3. copy all edges
            foreach(var vertex in nodes) {
                var cloneNode = mapping[vertex];
                foreach(var neighbor in vertex.neighbors)
                {
                    var cloneNeighbor = mapping[neighbor];
                    cloneNode.neighbors.Add(cloneNeighbor);
                }
            }
            return mapping[node];
        }

        private List<UndirectedGraphNode> GetAllNodes(UndirectedGraphNode head)
        {
            var queue = new Queue<UndirectedGraphNode>();
            var hashSet = new HashSet<UndirectedGraphNode>();
            queue.Enqueue(head);
            hashSet.Add(head);
            // BFS
            while(queue.Count > 0) {
                var currentNode = queue.Dequeue();
                foreach(var node in currentNode.neighbors) {
                    if(hashSet.Contains(node)) {
                        continue;
                    }
                    hashSet.Add(node);
                    queue.Enqueue(node);
                }
            }
            return hashSet.ToList();
        }

    }
}
