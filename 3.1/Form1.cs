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
    // Для пересоздания файла нужно нажать Ctrl + "Открыть файл", что в него будет записано можно
    //задать в фунции в конце класса формы
    // Библиотека классов - StudentsClass

    public partial class Form1 : Form
    {
        bool ok = false;
        BinaryFormatter formatter = new BinaryFormatter();
        Student[] deserilizeStudents;
        Class3_1 logic = new Class3_1();
        public Form1()
        {
            InitializeComponent();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    ok = true;
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                    {
                        Student[] dS= (Student[])formatter.Deserialize(fs);
                        deserilizeStudents = dS;
                        studentsBox.BeginUpdate(); // set elements in listbox
                        foreach (var s in dS)
                        {
                            studentsBox.Items.Add(s.FIO);
                        }                
                        studentsBox.EndUpdate();
                    }                   
                }
                catch (Exception except)
                {
                    ok = false;
                    MessageBox.Show(Convert.ToString(except));
                }
        }

        private void checkbutton_Click(object sender, EventArgs e)
        {
            if (studentsBox.SelectedIndex != -1 && ok)
			{
                if (logic.Process(studentsBox.SelectedIndex, deserilizeStudents))
                {
                    status.Text = "Долгов нет!";
                    status.Visible = true;
                }
                else
                {
                    status.Text = "Долги есть!";
                    status.Visible = true;
                }
            }
			else
			{
				status.Text = "Студент не выбран";
				status.Visible = true;				
			}
        }
        private void openFile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                uint[] s1 = new uint[] { 2, 3, 4, 5, 4, 3, 3, 4, 2, 5 };
                Student student1 = new Student("Ivan Obgorov", Convert.ToDateTime("27.04.1999"), s1, 5, 1);
                uint[] s2 = new uint[] { 5, 5, 4, 5, 4, 5, 4, 4, 5, 5 };
                Student student2 = new Student("Kamaz Dzagoev", Convert.ToDateTime("27.04.1999"), s2, 5, 2);
                Student[] students = new Student[] { student1, student2 };
                using (FileStream fs = new FileStream("Students.dat", FileMode.Create))
                {
                    formatter.Serialize(fs, students);
                }
            }
        }
    }
}
