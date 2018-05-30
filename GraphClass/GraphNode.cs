﻿using System;
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
        public List<double> Lengths { get; set; }
        public bool Visit { get; set; }
        public GraphNode(string name, List<GraphNode> co, bool visit)
        {
            Name = name;
            Co = co;
            Visit = visit;
        }
        public GraphNode(string name, List<GraphNode> co, bool visit, List<double> length)
        {
            Name = name;
            Co = co;
            Visit = visit;
            Lengths = length;
        }
        public GraphNode(GraphNode gn)
        {
            Name = gn.Name;
            Co = gn.Co;
            Visit = gn.Visit;
            Lengths = gn.Lengths;
        }
    }
    public class NodeComparer : IEqualityComparer<GraphNode>
    {
        public bool Equals(GraphNode gn1, GraphNode gn2)
        {
            if (ReferenceEquals(gn1, gn2)) return true;
            return gn1 != null && gn2 != null && gn1.Name.Equals(gn2.Name);
        }

        public int GetHashCode(GraphNode gn)
        {
            int hCode = gn.Name.GetHashCode();
            return hCode.GetHashCode();
        }
    }
}
