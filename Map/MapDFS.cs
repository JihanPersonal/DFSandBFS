using System.Collections.Generic;
namespace Traversal
{
    class MapDFS
    {
        private static MapNode startNode = MapInit.Init();
        private static List<int> result;
        private static HashSet<MapNode> visited;
        public static List<int> DFS()
        {
            result = new List<int>();
            visited = new HashSet<MapNode>();
            Traversal(startNode);
            return result;
        }
        private static void Traversal(MapNode node)
        {
            if (!visited.Contains(node))
            {
                visited.Add(node);
                result.Add(node.val);
                foreach (var nextnode in node.next)
                {
                    Traversal(nextnode);
                }
            }
        }
    }
}