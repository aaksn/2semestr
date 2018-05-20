using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{    
    public class Listc
    {
        public MyNode Head { get; set; }                    // голова списка
        public int Count { get; set; }                      // число элементов
        public Listc()                         // Конструктор
        {
            Head = null;
            Count = 0;
        }
        public void Add(int inf)                
        {
            MyNode p = new MyNode(inf, Head);
            Head = p;
            Count++;
        }
        public void Clear()
        {
            MyNode p = Head;
            Head = null;
            Count = 0;
        }
        public int Find(int val)         // Поиск узла
        {
            int num = 0;
            bool find = false;
            MyNode p = Head;
            bool ok = false;
            while ((p != null) && !ok)
            {
                num++;
                ok = p.Inf == val;
                if (!ok)
                    p = p.Next;
                else
                    find = true;
            }
            if (find)
                return Count - num + 1;
            else
                return -1;
            
        }
        
    }
}
