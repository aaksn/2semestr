using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code;
using System.Drawing.Drawing2D;

namespace Graph
{
    // Форма для рисования графа, инструкция в MainForm
    public partial class DrawGraph : Form
    {
        List<GraphE> elements = new List<GraphE>();
        public DrawGraph(List<GraphE> gr)
        {
            elements = gr;
            InitializeComponent();            
        }
        private void DrawGraph_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath path = new GraphicsPath();
            Font my = new Font("Courier New", 15, FontStyle.Bold);
            Pen pen = new Pen(Color.FromArgb(128, 0, 128), 4);
            pen.EndCap = LineCap.ArrowAnchor; 
            int k = elements.Count;
            int x = 30;
            for (int i = 0; i < k; i++)
            {
                
                if (elements[i].Co.Count != 0)
                {
                    foreach (var item in elements[i].Co)
                    {
                        int index = elements.IndexOf(item);
                        if (index!=i)
                        {
                            path.StartFigure();
                            path.AddLine(new Point(x, (int)Y(x)), new Point(30 + index * (360 / k), (int)Y(30 + index * (360 / k))));
                            pen.LineJoin = LineJoin.Round;                            
                            e.Graphics.DrawPath(pen, path);
                        }                        
                    }
                }
                //e.Graphics.DrawString(elements[i].Name, my, Brushes.Black, x , (int)Y(x) );
                x += 360 / k;
            }
            x = 30;
            for (int i = 0; i < k; i++)
            {
                e.Graphics.DrawString(elements[i].Name, my, Brushes.Black, x - 4, (int)Y(x));
                x += 360 / k;
            }
        }

        private double Y(double x)
        {
            return 100 * Math.Sin(x) + 200;
        }
    }
}
