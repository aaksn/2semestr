using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class BubbleSort
    {
        public int Sr { get; set; }
        
        public List<List<int>> Sort(List<int> arr)
        {
            List<List<int>> result = new List<List<int>>();
            int L = arr.Count;
            Sr = 0;
            for (int i = 1; i <= L - 1; i++)
            {
                for (int j = L - 1; j >= i; j--)
                {
                    Sr++;
                    if (arr[j - 1] > arr[j])
                    {                        
                        result.Add(ResultAdd(j, j - 1));
                        int tmp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = tmp;
                    }
                }
            }
            return result;
        }
        public List<int> ResultAdd(int n1, int n2)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                    res.Add(n1);
                if (i == 1)
                    res.Add(n2);
            }
            return res;
        }
    }
}
