using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class MyTree
    {
        public Tree Top { get; set; }
        
        int Levelcount { get; set; }
        private Tree Tmp { get; set; }
        public MyTree()
        {
            Top = null;            
            Levelcount = 0;
        }
        public void Add(Tree tree, int data, int treeanchor, bool isbrother)  // вставка
        {
            tree = Search(treeanchor, tree);
            if (tree == null)
            {                
                Top = new Tree(null, null, data);                
                Levelcount++;
            }                
            else if (treeanchor == Convert.ToInt32(tree.Data))
            {
                Insert(tree, data, isbrother);                
            } 
        }
        public void AddStart(int val, int treeanchor, bool isbrother)               // поиск и вставка
        {
            Add(Top, val, treeanchor, isbrother);
        }
        public Tree Search(int val, Tree tr)
        {
            if (tr == null)
            {
                return null;
            }
            else
            {
                if (tr.Data == val)
                    return tr;
                return SearchingRecursion(tr, val);
            }
        }

        public Tree SearchingRecursion(Tree tr, int val)
        {
            if (tr.Data == val)
                Tmp = tr;
            for (Tree t = tr; t != null; t = t.Brother)
            {
                if (t.Son != null)
                {
                    if (t.Data == val)
                        Tmp = t;
                    SearchingRecursion(t.Son, val);
                }
                if (t.Brother != null)
                {
                    SearchingRecursion(t.Brother, val);
                }
            }
            return Tmp;
            
        }
        public void Insert(Tree tree, int data, bool isbrother)
        {
            if (isbrother)
                tree.Brother = new Tree(null, null, data);                
            else
            {
                tree.Son = new Tree(null, null, data);
                Levelcount++;
            }
        }
    }
}
