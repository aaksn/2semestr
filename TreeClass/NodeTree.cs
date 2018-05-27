using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class NodeTree
    {
        public int Data { get; set; }
        public NodeTree Son { get; set; }
        public NodeTree Brother { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public NodeTree(NodeTree son, NodeTree brother, int data, int x, int y) // конструктор
        {
            Son = son;
            Brother = brother;
            Data = data;
            X = x;
            Y = y;
        }
    }
}
