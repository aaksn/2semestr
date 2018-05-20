using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bubble_Click(object sender, EventArgs e)
        {
            Bubble b = new Bubble();
            b.Show();
        }

        private void shaker_Click(object sender, EventArgs e)
        {
            Shaker s = new Shaker();
            s.Show();
        }

        private void sr_Click(object sender, EventArgs e)
        {
            Sr sr = new Sr();
            sr.Show();
        }

        private void pe_Click(object sender, EventArgs e)
        {
            Pe pe = new Pe();
            pe.Show();
        }
    }
}
