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
using System.Runtime.Serialization.Formatters.Binary;


namespace _3._1
{
    //1.	Убедиться в отсутствии задолженностей для выбранного студента-выпускника(наличие
    //положительных оценок за все десять семестров).
    //
    // Для пересоздания файла нужно нажать Ctrl + "Открыть файл", в него зададутся 8 случайных студентов
    // Библиотека классов - StudentsClass

    public partial class Form1 : Form
    {      
        Serialization mystud = new Serialization();        
        public Form1()
        {
            InitializeComponent();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            status.Visible = false;
            marksl.Visible = false;
            studentsBox.Items.Clear();
            openFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                try
                {                    
                    mystud.DeSerialize(openFileDialog.FileName);
                    studentsBox.BeginUpdate(); // set elements in listbox
                    foreach (var s in mystud.Students)
                    {
                        studentsBox.Items.Add(s.FIO);
                    }
                    studentsBox.EndUpdate();
                }
                catch (Exception except)
                {                    
                    MessageBox.Show(Convert.ToString(except));
                }
        }

        private void checkbutton_Click(object sender, EventArgs e)
        {
            if (studentsBox.SelectedIndex != -1 && mystud.Students.Count != 0)
			{                
                if (mystud.Students[studentsBox.SelectedIndex].Process())
                {
                    status.Text = "Долгов нет!";
                    status.Visible = true;
                    marksl.Text = mystud.Marks(studentsBox.SelectedIndex);
                    marksl.Visible = true;
                }
                else
                {
                    status.Text = "Долги есть!";
                    status.Visible = true;
                    marksl.Text = mystud.Marks(studentsBox.SelectedIndex);
                    marksl.Visible = true;
                }
            }
			else
			{
				status.Text = "Студент не выбран";
				status.Visible = true;
                marksl.Visible = false;
            }
        }
        private void openFile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {                
                mystud.Serialize("Students.dat");
            }
        }

        private void studentsBox_DoubleClick(object sender, EventArgs e)
        {
            checkbutton_Click(sender, e);
        }
    }
}
