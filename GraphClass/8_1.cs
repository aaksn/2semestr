using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class WorkWithGraph
    {        
        public List<GraphE> SearchStart(string name, List<GraphE> list)
        {
            ClearVisit(list);
            List<GraphE> tmp = new List<GraphE>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Name == name)
                    Search(list[i]);
            }
            foreach (var item in list)
            {
                if (item.Visit == false)
                    tmp.Add(item);
            }
            return tmp;
        }
        public void Search(GraphE el)
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
        public void ClearVisit(List<GraphE> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Visit = false;
            }
        }
    }
}
