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
using Graphic;

namespace Graph
{
    //1.	Найти все вершины графа, недостижимые из заданной.
    // (использовать рекурсивную процедуру проверки доступности одной вершины из другой.)
    //
    //На форме отображается матрица смежности, с её помощью можно задать связи между элементами графа.
    //Количество элементов изменяется с помощью кнопок '+' и '-' на форме.
    //При нажатии на 'Search' - выведутся все вершины, недостижимые из заданной (выбирается в выпадающем списке).
    //При нажатии на 'Draw' отобразится графическое представление графа.
    //
    // Библиотека классов - GraphClass
    public partial class MainForm : Form
    {        
        WorkWithMatrix wwm = new WorkWithMatrix();
        string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public MainForm()
        {
            InitializeComponent();
        }

        private void addb_Click(object sender, EventArgs e)
        {
            int k = liste.Items.Count;
            matrix.Columns.Add(letters[k].ToString(), letters[k].ToString());
            matrix.Rows.Add(1);
            matrix.Rows[k].HeaderCell.Value = letters[k].ToString();
            liste.Items.Add(letters[k]);
            string[] row = new string[k + 1];
            for (int i = 0; i < k; i++)
            {
                Random rnd = new Random();
                row[i] = "0";
            }
            row[k] = "1";
            matrix.Rows[k].SetValues(row);
            for (int i = 0; i < k; i++)
            {
                
                matrix[k, i].Value = "0";
            }
        }
        private void delb_Click(object sender, EventArgs e)
        {
            if (liste.Items.Count > 1)
            {
                int k = liste.Items.Count;
                matrix.Columns.RemoveAt(k - 1);
                matrix.Rows.RemoveAt(k - 1);
                liste.Items.RemoveAt(k - 1);
            }            
        }
        private void search_Click(object sender, EventArgs e)
        {
            string r = "";
            MyGraph mygraph = new MyGraph(wwm.Parser(matrix));            
            List<GraphNode> result = mygraph.SearchStart(liste.SelectedItem.ToString());
            foreach (var item in result)
            {
                r += item.Name;
                r += " ";
            }
            if (result.Count!=0)
                MessageBox.Show(r, "Недостижимые вершины:");
            else MessageBox.Show("Все вершины достижимы");
        }

        private void drawb_Click(object sender, EventArgs e)
        {
            DrawGraph dg = new DrawGraph(wwm.Parser(matrix));
            dg.Show();
        }
    }
}
