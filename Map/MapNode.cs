using System.Collections.Generic;
namespace Traversal
{
    public class MapNode
    {
        public int val;
        public List<MapNode> next = new List<MapNode>();
        public MapNode(int x) { val = x; }
    }

    public class MapInit
    {
        public static MapNode Init()
        {
            MapNode second = new MapNode(2);
            MapNode zero = new MapNode(0);
            MapNode three = new MapNode(3);
            MapNode one = new MapNode(1);
            second.next.Add(zero);
            second.next.Add(three);
            zero.next.Add(second);
            zero.next.Add(one);
            one.next.Add(second);
            three.next.Add(three);
            return second;
        }
    }
}