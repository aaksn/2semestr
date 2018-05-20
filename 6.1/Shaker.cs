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

namespace _6._1
{
    public partial class Shaker : Form
    {
        private int counter = 0;
        private int step = 0;
        Move move = new Move();
        ShakerSort shakersort = new ShakerSort();
        List<int> listofelements = new List<int>();
        List<TextBox> boxes = new List<TextBox>();
        List<List<int>> listofsteps = new List<List<int>>();
        public Shaker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listofelements.Clear();
            boxes.Clear();
            Elements();
            listofsteps = shakersort.Sort(listofelements);
            step = 0;
            timer1.Enabled = true;
            counter = 0;
            Console.WriteLine(timer1.ToString());
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (step < listofsteps.Count)
            {
                TextBox box1 = boxes[listofsteps[step][0]];
                TextBox box2 = boxes[listofsteps[step][1]];
                if (move.This(box1, box2, counter))
                {
                    step++;
                    counter = 0;
                    move.Change(ref box1, ref box2, box1.Location.X, box1.Location.Y, box1.Text, box2.Location.X, box2.Location.Y, box2.Text);
                }
                else
                {
                    counter++;
                }
            }
            else timer1.Enabled = false;
        }

        private void rndbutton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            foreach (var item in Controls.OfType<TextBox>())
            {
                item.Text = rnd.Next(100).ToString();
            }
        }
        private void Elements()
        {
            try
            {
                listofelements.Add(Convert.ToInt16(textBox1.Text));
                boxes.Add(textBox1);
                listofelements.Add(Convert.ToInt16(textBox2.Text));
                boxes.Add(textBox2);
                listofelements.Add(Convert.ToInt16(textBox3.Text));
                boxes.Add(textBox3);
                listofelements.Add(Convert.ToInt16(textBox4.Text));
                boxes.Add(textBox4);
                listofelements.Add(Convert.ToInt16(textBox5.Text));
                boxes.Add(textBox5);
                listofelements.Add(Convert.ToInt16(textBox6.Text));
                boxes.Add(textBox6);
                listofelements.Add(Convert.ToInt16(textBox7.Text));
                boxes.Add(textBox7);
                listofelements.Add(Convert.ToInt16(textBox8.Text));
                boxes.Add(textBox8);
                listofelements.Add(Convert.ToInt16(textBox9.Text));
                boxes.Add(textBox9);
                listofelements.Add(Convert.ToInt16(textBox10.Text));
                boxes.Add(textBox10);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
