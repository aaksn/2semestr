using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class MyTree
    {
        public NodeTree Top { get; set; }
        public int Widht { get; set; }
        public int Height { get; set; }
        NodeTree Tmp = null;
        public MyTree()
        {
            Top = null;
            Widht = 1;
            Height = 0;
        }
        public void Add(NodeTree tree, int data, int treeanchor, bool isbrother)  // вставка
        {
            tree = Search(treeanchor, tree);
            if (tree == null)
            {
                Top = new NodeTree(null, null, data, Widht, Height);
                Height++;
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
        public NodeTree Search(int val, NodeTree tr)
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
        public NodeTree SearchingRecursion(NodeTree tr, int val)
        {
            if (tr.Data == val)
                Tmp = tr;
            for (NodeTree t = tr; t != null; t = t.Brother)
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
        public void Insert(NodeTree tree, int data, bool isbrother)
        {
            if (isbrother)
            {
                Widht++;
                tree.Brother = new NodeTree(null, null, data, Widht, Height);
            }
            else
            {
                Widht = tree.X;
                Height = tree.Y + 1;
                tree.Son = new NodeTree(null, null, data, Widht, Height);                
            }
            
        }
        public List<List<int>> TreeRoad()
        {
            List<List<int>> res = new List<List<int>>();
            List<int> wsons = new List<int>();
            List<int> elements = new List<int>();
            NodeTreeWithoutSons(Top, wsons);
            AllElements(Top, elements);
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
        public List<int> NodeTreeWithoutSons(NodeTree tr, List<int> elmnts)
        {
            for (NodeTree t = tr; t != null; t = t.Brother)
            {
                if (t.Son == null)
                    elmnts.Add(t.Data);
                else
                    NodeTreeWithoutSons(t.Son, elmnts);
            }
            return elmnts;
        }
        public List<int> AllElements(NodeTree tr, List<int> elmnts)
        {
            for (NodeTree t = tr; t != null; t = t.Brother)
            {
                elmnts.Add(t.Data);
                if (t.Son != null)
                    AllElements(t.Son, elmnts);
            }
            return elmnts;
        }
    }
}
