using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class MyNode     // Узел для списка, стека, очереди
    {
        public int Inf { get; set; }
        public MyNode Next { get; set; }
        public MyNode(int inf, MyNode next)    // Конструктор
        {
            Inf = inf;
            Next = next;
        }
    }
}
