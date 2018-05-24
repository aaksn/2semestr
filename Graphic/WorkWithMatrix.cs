using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code;
using System.Windows.Forms;

namespace Graphic
{
    public class WorkWithMatrix
    {
        public List<GraphNode> Parser(DataGridView dgv)
        {
            List<GraphNode> list = new List<GraphNode>();
            int c = dgv.ColumnCount;
            for (int i = 0; i < c; i++)
            {
                list.Add(new GraphNode(dgv.Columns[i].Name, new List<GraphNode>(), false));
            }
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (Convert.ToInt16(dgv[i, j].Value) != 0)
                    {
                        list[j].Co.Add(list[i]);
                    }
                }
            }
            return list;
        }
        public List<GraphNode> ParserWithLength(DataGridView dgv)
        {
            List<GraphNode> list = new List<GraphNode>();
            int c = dgv.ColumnCount;
            for (int i = 0; i < c; i++)
            {
                list.Add(new GraphNode(dgv.Columns[i].Name, new List<GraphNode>(), false, new List<int>()));
            }
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    int value = Convert.ToInt16(dgv[i, j].Value);
                    if (value != 0)
                    {
                        list[j].Co.Add(list[i]);
                        list[j].Lengths.Add(value);
                    }
                }
            }
            return list;
        }
    }
}
