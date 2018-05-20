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

namespace _5._1
{
    public partial class Form1 : Form
    {
        Listc lst;
        public Form1()
        {
            InitializeComponent();
            lst = new Listc();
        }

        private void findbutton_Click(object sender, EventArgs e)
        {
            string[] liststring = listbox.Text.Split(' ');
            int[] list = new int[liststring.Length];            
            for (int i = 0; i < liststring.Length; i++)
            {
                try
                {
                    list[i] = Convert.ToInt32(liststring[i]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString()); 
                }
            }
            lst.Clear();            
            foreach (var item in list)
            {
                lst.Add(item);
            }
            try
            {
                numofelement.Text = lst.Find(Convert.ToInt32(findelementBox.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }
    }
}
