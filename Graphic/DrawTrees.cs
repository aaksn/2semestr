using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class DrawTrees
    {
        public string[] DT(string[] lines)
        {
            List<string> result = new List<string>();
            List<List<string>> tmp = new List<List<string>>();
            List<List<string>> tmp2 = new List<List<string>>();
            foreach (var item in lines)
            {
                tmp.Add(item.Split(' ').ToList());
            }            
            foreach (var item in tmp)
            {
                for (int i = 1; i < item.Count; i++)
                {
                    tmp2.Add(item.GetRange(0, i));
                }
            }
            foreach (var item in tmp2)
            {
                for (int i = 0; i < item.Count - 1; i++)
                {
                    item[i] = "-";
                }
            }
            for (int i = 0; i < tmp2.Count; i++)
            {
                result.Add("");
                foreach (var item in tmp2[i])
                {
                    result[i] += item;
                    result[i] += " ";
                }
            }
            
            return result.Distinct().ToArray();
        }
    }
}
