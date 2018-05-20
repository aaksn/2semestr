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
using System.IO;

namespace _3._1
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
                    Class4_1 logic = new Class4_1(inputOpenFileDialog.FileName);
                    symbolcounter.Text = Convert.ToString(logic.Process());
                }
                catch (Exception except)
                {                    
                    MessageBox.Show(Convert.ToString(except));
                }
        }
    }
}
