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
        public List<GraphE> Parser(DataGridView dgv)
        {
            List<GraphE> list = new List<GraphE>();
            int c = dgv.ColumnCount;
            for (int i = 0; i < c; i++)
            {
                list.Add(new GraphE(dgv.Columns[i].Name, new List<GraphE>(), false));
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
    }
}
