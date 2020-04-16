using System.Collections.Generic;
namespace Traversal
{
    class MapBFS
    {
        private static MapNode startNode = MapInit.Init();
        private static List<int> result;
        public static List<int> BFS()
        {
            result = new List<int>();
            Traversal(startNode);
            return result;
        }

        private static void Traversal(MapNode node)
        {
            HashSet<MapNode> visited = new HashSet<MapNode>();
            Queue<MapNode> queue = new Queue<MapNode>();
            queue.Enqueue(startNode);

            while (queue.Count > 0)
            {
                MapNode curr = queue.Dequeue();
                result.Add(curr.val);
                visited.Add(curr);
                foreach (MapNode next in curr.next)
                {
                    if (!visited.Contains(next))
                    {
                        queue.Enqueue(next);
                    }
                }
            }
        }
    }
}