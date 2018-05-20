using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class ShakerSort
    {
        public int Sr { get; set; }
        public List<List<int>> Sort(List<int> arr)
        {
            List<List<int>> result = new List<List<int>>();
            int L = arr.Count;
            int left = 1, right = arr.Count - 1, last = right;
            Sr = 0;
            do
            {
                for (int j = right; j >= left; j--)
                {
                    Sr++;
                    if (arr[j - 1] > arr[j])
                    {
                        result.Add(ResultAdd(j, j - 1));
                        int t = arr[j - 1]; arr[j - 1] = arr[j]; arr[j] = t;
                        last = j;
                    }
                }                    
                left = last;
                for (int j = left; j <= right; j++)
                {
                    Sr++;
                    if (arr[j - 1] > arr[j])
                    {
                        result.Add(ResultAdd(j, j - 1));
                        int t = arr[j - 1]; arr[j - 1] = arr[j]; arr[j] = t;
                        last = j;
                    }
                }                    
                right = last - 1;
            }
            while (left < right);
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
