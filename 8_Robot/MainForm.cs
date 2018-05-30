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

namespace _8_Robot
{
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
            int k = matrix.ColumnCount;
            matrix.Columns.Add(letters[k].ToString(), letters[k].ToString());
            matrix.Rows.Add(1);
            matrix.Rows[k].HeaderCell.Value = letters[k].ToString();
            foreach (var cb in Controls.OfType<ComboBox>())
            {
                cb.Items.Add(letters[k]);
            }
            string[] row = new string[k + 1];
            for (int i = 0; i < k; i++)
            {
                row[i] = "0"; // 0
            }
            row[k] = "0";
            matrix.Rows[k].SetValues(row);
            for (int i = 0; i < k; i++)
            {
                matrix[k, i].Value = "0"; // 0
            }
        }
        private void delb_Click(object sender, EventArgs e)
        {
            if (matrix.ColumnCount > 1)
            {
                int k = matrix.ColumnCount;
                matrix.Columns.RemoveAt(k - 1);
                matrix.Rows.RemoveAt(k - 1);
                foreach (var cb in Controls.OfType<ComboBox>())
                {
                    cb.Items.RemoveAt(k - 1);
                }
            }
        }

        private void drawb_Click(object sender, EventArgs e)
        {
            DrawGraph dg = new DrawGraph(wwm.Parser(matrix));
            dg.Show();
        }

        private void start_Click(object sender, EventArgs e)
        {
            double mintime = -1;
            //try
            //{                
            //    Robot robot = new Robot(wwm.ParserWithLength(matrix));
            //    if (r3chek.Checked)
            //        mintime = robot.MinTimeSearch(pointr1.Text, speedr1.SelectedIndex + 1,
            //            pointr2.Text, speedr2.SelectedIndex + 1,
            //            pointr3.Text, speedr3.SelectedIndex + 1);
            //    else mintime = robot.MinTimeSearch(pointr1.Text, speedr1.SelectedIndex + 1,
            //        pointr2.Text, speedr2.SelectedIndex + 1);
            //    if (mintime == -1)
            //        MessageBox.Show("Встреча роботов невозможна :(");
            //    else MessageBox.Show(mintime.ToString(), "Минимальное время:");
            //}
            //catch (Exception z)
            //{
            //    MessageBox.Show(z.ToString(), "Ошибка в заполнении таблицы");
            //}
            Robot robot = new Robot(wwm.ParserWithLength(matrix));
            if (r3chek.Checked)
                mintime = robot.MinTimeSearch(pointr1.Text, speedr1.SelectedIndex + 1,
                    pointr2.Text, speedr2.SelectedIndex + 1,
                    pointr3.Text, speedr3.SelectedIndex + 1);
            else mintime = robot.MinTimeSearch(pointr1.Text, speedr1.SelectedIndex + 1,
                pointr2.Text, speedr2.SelectedIndex + 1);
            if (mintime == -1)
                MessageBox.Show("Встреча роботов невозможна :(");
            else MessageBox.Show(mintime.ToString(), "Минимальное время:");

        }

        private void r3chek_CheckedChanged(object sender, EventArgs e)
        {
            if (r3chek.Checked)
            {
                pointr3.Enabled = true;
                speedr3.Enabled = true;
            }
            else
            {
                pointr3.Enabled = false;
                speedr3.Enabled = false;
            }
        }
    }
}
