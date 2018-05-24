using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class WorkWithTree
    {        
        public void TreeConstruct(int count, MyTree tr)
        {
            Random rnd = new Random();
            List<int> lste = new List<int>();
            for (int i = 0; i < count; i++)
            {
                lste.Add(rnd.Next(10 * i, 10 * (i + 1)));
            }

            tr.AddStart(lste[0], 0, false);
            tr.AddStart(lste[1], lste[0], false);
            tr.AddStart(lste[2], lste[1], true);
            tr.AddStart(lste[3], lste[2], true);
            tr.AddStart(lste[4], lste[1], false);
            tr.AddStart(lste[5], lste[4], true);
            tr.AddStart(lste[6], lste[3], false);
            tr.AddStart(lste[7], lste[6], false);
        }
        public List<List<int>> TreeRoad(MyTree mytr) //дороги в Tree
        {
            List<List<int>> res = new List<List<int>>();
            List<int> wsons = new List<int>();
            List<int> elements = new List<int>();
            TreeWithoutSons(mytr.Top, wsons);
            AllElements(mytr.Top, elements);
            for (int i = 0; i < wsons.Count; i++)
            {
                int e = wsons[i];                
                int index = elements.IndexOf(e);
                res.Add(elements.GetRange(0, index + 1));
                if (index != elements.Count - 1)
                {
                    if (e < elements[index + 1])
                        elements.Remove(e);                    
                    else
                    {
                        for (int j = index; j != 0; j--)
                        {
                            elements.RemoveAt(j);
                        }
                    }
                }                
            }
            return res;
        }
        public List<int> TreeWithoutSons(Tree tr, List<int> elmnts)
        {
            for (Tree t = tr; t != null; t = t.Brother)
            {
                if (t.Son == null)
                    elmnts.Add(t.Data);
                else
                    TreeWithoutSons(t.Son, elmnts);
            }
            return elmnts;
        }
        public List<int> AllElements(Tree tr, List<int> elmnts)
        {
            for (Tree t = tr; t != null; t = t.Brother)
            {
                elmnts.Add(t.Data);
                if (t.Son != null)
                    AllElements(t.Son, elmnts);
            }
            return elmnts;
        }
    }
}
