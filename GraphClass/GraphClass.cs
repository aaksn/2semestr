using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class GraphE
    {
        public string Name { get; set; }
        public List<GraphE> Co { get; set; }
        public List<int> Lengths { get; set; }
        public bool Visit { get; set; }
        public GraphE(string name, List<GraphE> co, bool visit)
        {
            Name = name;
            Co = co;
            Visit = visit;
        }
        public GraphE(string name, List<GraphE> co, bool visit, List<int> length)
        {
            Name = name;
            Co = co;
            Visit = visit;
            Lengths = length;
        }
    }
}
