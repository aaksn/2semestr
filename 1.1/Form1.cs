using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Code;

namespace _1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void openFile_Click(object sender, EventArgs e)
        {
            if (inputOpenFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    inputOpenFileDialog.InitialDirectory = Path.GetDirectoryName(inputOpenFileDialog.FileName);
                    Class1_1 logic = new Class1_1(inputOpenFileDialog.FileName);
                    //logic.Process(out int strcount, out int symbcount);
                    //stringcounter.Text = strcount.ToString();
                    //symbolcounter.Text = symbcount.ToString();
                }
                catch (Exception except)
                {
                    MessageBox.Show(Convert.ToString(except));
                }
        }        
    }
}
