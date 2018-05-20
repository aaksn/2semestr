using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Code;

namespace _6._1
{
    public partial class Sr : Form
    {
        public Sr()
        {
            InitializeComponent();
            Go();
        }
        public void Go()
        {
            //Bubble
            Series mySeriesOfPoint = new Series("Bubble");
            mySeriesOfPoint.ChartType = SeriesChartType.Spline;
            mySeriesOfPoint.BorderWidth = 3;
            mySeriesOfPoint.Color = Color.Red;
            BubbleSort bubblesort = new BubbleSort();
            List<int> listofelements = new List<int>();
            listofelements.Add(0);
            for (double x = 0; x <= 2000; x += 100)
            {
                bubblesort.Sort(listofelements);
                mySeriesOfPoint.Points.AddXY(x, bubblesort.Sr);
                listofelements.AddRange(RndElements(100));
            }
            gpe.Series.Add(mySeriesOfPoint);
            
            //Shaker
            Series mySeriesOfPoint2 = new Series("Shaker");
            mySeriesOfPoint2.ChartType = SeriesChartType.Spline;
            mySeriesOfPoint2.BorderWidth = 3;
            mySeriesOfPoint2.Color = Color.Blue;
            ShakerSort shakersort = new ShakerSort();
            List<int> listofelements2 = new List<int>();
            listofelements2.Add(0);
            listofelements2.Add(1);
            for (double x = 0; x <= 2000; x += 100)
            {
                shakersort.Sort(listofelements2);
                mySeriesOfPoint2.Points.AddXY(x, shakersort.Sr);
                if (x == 0)
                    listofelements2.AddRange(RndElements(99));
                else listofelements2.AddRange(RndElements(100));
            }
            gpe.Series.Add(mySeriesOfPoint2);

        }
        public List<int> RndElements(int count)
        {
            Random rnd = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < count; i++)
            {
                list.Add(rnd.Next(100));
            }
            return list;
        }

        private void processinglabel_VisibleChanged(object sender, EventArgs e)
        {
            Go();
        }
    }
}
