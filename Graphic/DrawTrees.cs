using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace Code
{
    public class DrawTrees
    {
        public static void DrawT(PaintEventArgs e, List<List<int>> list, MyTree myT)
        {
            if (list != null)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Font my = new Font("Arial", 10, FontStyle.Bold);
                Pen pen = new Pen(Color.FromArgb(128, 0, 128), 3)
                {
                    EndCap = LineCap.ArrowAnchor
                };
                List<List<int>> cn = new List<List<int>>();
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = 1; j < list[i].Count; j++)
                    {                        
                        cn.Add(new List<int> { list[i][j - 1], list[i][j] });
                    }
                }                
                int k = 100; // zoom
                int k2 = 8;
                foreach (var item in cn)
                {
                    NodeTree one = myT.Search(item[0], myT.Top);
                    e.Graphics.DrawString(one.Data.ToString(), my, Brushes.Black, k * one.X - k2, k * one.Y );
                    NodeTree two = myT.Search(item[1], myT.Top);
                    e.Graphics.DrawString(two.Data.ToString(), my, Brushes.Black, k * two.X - k2, k * two.Y );
                    e.Graphics.DrawLine(pen, k*one.X, k*one.Y+20, k * two.X, k * two.Y);                    
                }                
            }
        }
        public static string[] DT(string[] lines)
        {
            List<string> result = new List<string>();
            List<List<string>> tmp = new List<List<string>>();
            List<List<string>> tmp2 = new List<List<string>>();
            foreach (var item in lines)
            {
                tmp.Add(item.Split(' ').ToList());
            }            
            foreach (var item in tmp)
            {
                for (int i = 1; i < item.Count; i++)
                {
                    tmp2.Add(item.GetRange(0, i));
                }
            }
            foreach (var item in tmp2)
            {
                for (int i = 0; i < item.Count - 1; i++)
                {
                    item[i] = "-";
                }
            }
            for (int i = 0; i < tmp2.Count; i++)
            {
                result.Add("");
                foreach (var item in tmp2[i])
                {
                    result[i] += item;
                    result[i] += " ";
                }
            }
            
            return result.Distinct().ToArray();
        }        
    }
}
