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

namespace _2._1
{
    // Можно ли записать файл по пути из строки
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pathBOX, "Путь для создания файла");
        }

        private void gobutton_Click(object sender, EventArgs e)
        {
            Class2_1 logic = new Class2_1(pathBOX.Text);
            if (logic.Process())
                statuslabel.Text = "True";
            else statuslabel.Text = "False";
        }
    }
}
