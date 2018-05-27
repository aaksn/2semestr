using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Code
{
    public class WorkWithTree
    {        
        public void TreeConstruct(int count, MyTree tr) // Вспомогательный метод для создания списка
        {
            Thread.Sleep(20);
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
    }
}
