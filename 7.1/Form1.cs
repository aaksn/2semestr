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
using Code;

namespace _7._1
{
    //1.	Дано упорядоченное дерево глубины N(> 0),
    //каждая внутренняя вершина которого имеет K(< 9) непосредственных потомков,
    //которые нумеруются от 1 до K.Корень дерева имеет номер 0.
    //Записать в текстовый файл все возможные пути, ведущие от корня к листьям
    //(каждый путь записывается в отдельной строке файла).
    //Перебирать пути, начиная с "самого левого" и заканчивая "самым правым",
    //при этом первыми заменять конечные элементы пути.
    //
    // Библиотека классов - TreeClass
    
    public partial class Form1 : Form
    {
        string[] lines;
        List<List<int>> paths;
        MyTree myTree;
        public Form1()
        {
            InitializeComponent();
        }
        private void rndbutton_Click(object sender, EventArgs e)
        {
            myTree = new MyTree();
            WorkWithTree work = new WorkWithTree();            
            work.TreeConstruct(8, myTree);
            paths = myTree.TreeRoad();            
            lines = new string[paths.Count];
            for (int i = 0; i < paths.Count; i++)
            {
                string tmp = "";
                foreach (var item in paths[i])
                {
                    tmp += item.ToString();
                    tmp += " ";
                }
                lines[i] = tmp;
            }
            outtreeonform.Clear();
            outtreeonform.TextAlign = HorizontalAlignment.Left;
            //outtreeonform.Lines = DrawTrees.DT(lines);
            outtreeonform.Lines = lines;
            label2.Text = null;                        
            label2.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFile.InitialDirectory = Path.GetDirectoryName(saveFile.FileName);
            if (lines != null && saveFile.ShowDialog() == DialogResult.OK)
                try
                {
                    File.WriteAllLines(saveFile.FileName, lines);
                }
                catch (Exception except)
                {
                    MessageBox.Show(Convert.ToString(except));
                }
        }

        private void label2_Paint(object sender, PaintEventArgs e)
        {
            DrawTrees.DrawT(e, paths, myTree);
        }
    }
}
