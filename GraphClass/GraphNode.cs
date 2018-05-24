using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class GraphNode
    {
        public string Name { get; set; }
        public List<GraphNode> Co { get; set; }
        public List<int> Lengths { get; set; }
        public bool Visit { get; set; }
        public GraphNode(string name, List<GraphNode> co, bool visit)
        {
            Name = name;
            Co = co;
            Visit = visit;
        }
        public GraphNode(string name, List<GraphNode> co, bool visit, List<int> length)
        {
            Name = name;
            Co = co;
            Visit = visit;
            Lengths = length;
        }
    }
}
