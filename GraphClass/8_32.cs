using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class Robot
    {
        List<GraphNode> GraphNodes { get; set; }
        public Robot(List<GraphNode> list)
        {
            GraphNodes = list;
        }        
        public double MinTimeSearch(string pointr1, int speedr1, string pointr2, int speedr2) // Для 2 роботов
        {
            if (pointr1 == pointr2)
                return 0;
            GraphNode r1 = SearchNode(pointr1);
            GraphNode r2 = SearchNode(pointr2);                        
            double mt = 0;
            bool meet = false;
            List<GraphNode> nowr1 = new List<GraphNode> { r1 };
            List<GraphNode> nowr2 = new List<GraphNode> { r2 };
            List<GraphNode> tmp1 = new List<GraphNode>();
            List<GraphNode> tmp2 = new List<GraphNode>();
            while (!meet & (nowr1.Count != 0 & nowr2.Count != 0))
            {
                mt += 0.5;
                Step(ref tmp1, ref nowr1, speedr1);
                Step(ref tmp2, ref nowr2, speedr2);                
                if (tmp1.Except(tmp2, new NodeComparer()).Count() != 0)
                    meet = true;
                if (tmp1.Count == 0 & tmp2.Count == 0 & nowr1.Count == 0 & nowr2.Count == 0 & !meet)
                    return -1;
                if (mt > 2000)
                    break;
            }
            if (!meet)
                return -1;
            else
                return mt;
        }
        public double MinTimeSearch(string pointr1, int speedr1, string pointr2, int speedr2, string pointr3, int speedr3) // Для 3 роботов
        {
            if (pointr1 == pointr2 && pointr1 == pointr3)
                return 0;
            GraphNode r1 = SearchNode(pointr1);
            GraphNode r2 = SearchNode(pointr2);
            GraphNode r3 = SearchNode(pointr3);
            double mt = 0;
            bool meet = false;
            List<GraphNode> nowr1 = new List<GraphNode> { r1 };
            List<GraphNode> nowr2 = new List<GraphNode> { r2 };
            List<GraphNode> nowr3 = new List<GraphNode> { r3 };
            List<GraphNode> tmp1 = new List<GraphNode>();
            List<GraphNode> tmp2 = new List<GraphNode>();
            List<GraphNode> tmp3 = new List<GraphNode>();
            while (!meet & (nowr1.Count != 0 & nowr2.Count != 0 & nowr2.Count!=0))
            {
                mt += 0.5;
                Step(ref tmp1, ref nowr1, speedr1);
                Step(ref tmp2, ref nowr2, speedr2);
                Step(ref tmp3, ref nowr3, speedr3);
                if (tmp1.Except(tmp2.Except(tmp3, new NodeComparer()), new NodeComparer()).Count() != 0)
                    meet = true;
                if (tmp1.Count == 0 & tmp2.Count == 0 & tmp3.Count == 0
                    & nowr1.Count == 0 & nowr2.Count == 0 & nowr3.Count == 0 & !meet)
                    return -1;
                if (mt > 2000)
                    break;
            }
            if (!meet)
                return -1;
            else
                return mt;
        }
        private GraphNode SearchNode(string name)
        {
            int c = 0;            
            List<GraphNode> t = new List<GraphNode>();
            foreach (var item in GraphNodes)
            {
                t.Add(new GraphNode(item));
            }            
            while (t[c].Name != name && c < t.Count)
            {
                c++;
            }
            return t[c];
        }
        private void ReLengths(List<GraphNode> t)
        {
            for (int i = 0; i < t.Count; i++)
            {
                t[i] = SearchNode(t[i].Name);
            }
        }
        private void Step(ref List<GraphNode> tmp, ref List<GraphNode> nowr, int speed)
        {
            tmp.Clear();
            for (int j = 0; j < nowr.Count; j++)
            {                
                int z = 0;
                while (j < nowr.Count && z < nowr[j].Lengths.Count)
                {
                    nowr[j].Lengths[z] -=  (0.5 * speed);
                    if (nowr[j].Lengths[z] == 0)
                        tmp.Add(nowr[j].Co[z]);
                    z++;
                }              
                int p = nowr[j].Co.Count - 1;
                while (p>=0)
                {
                    if (nowr[j].Lengths[p] == 0)
                        nowr[j].Co.RemoveAt(p);                    
                    p--;
                }
                if (nowr[j].Co.Count == 0)
                    nowr.RemoveAt(j);
            }
            ReLengths(tmp);
            nowr.AddRange(tmp);
        }
    }
}
