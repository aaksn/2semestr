using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class Tree
    {
        public int Data { get; set; }
        public Tree Son { get; set; }
        public Tree Brother { get; set; } 
        public Tree(Tree son, Tree brother, int data) // конструктор
        {
            Son = son;
            Brother = brother;
            Data = data;
        }
    }
}
