using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class MyGraph
    {
        public List<GraphNode> GraphNodes { get; set; }
        public MyGraph(List<GraphNode> gn)
        {
            GraphNodes = gn;
        }
        public List<GraphNode> SearchStart(string name)
        {
            ClearVisit();
            List<GraphNode> tmp = new List<GraphNode>();
            for (int i = 0; i < GraphNodes.Count; i++)
            {
                if (GraphNodes[i].Name == name)
                    Search(GraphNodes[i]);
            }
            foreach (var item in GraphNodes)
            {
                if (item.Visit == false)
                    tmp.Add(item);
            }
            return tmp;
        }
        private void Search(GraphNode el)
        {
            if (el.Visit == false)
            {
                foreach (var item in el.Co)
                {
                    el.Visit = true;
                    Search(item);                
                }
            }            
        }
        private void ClearVisit()
        {
            for (int i = 0; i < GraphNodes.Count; i++)
            {
                GraphNodes[i].Visit = false;
            }
        }
    }
}
