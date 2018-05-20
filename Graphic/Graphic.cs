using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Code
{
    public class Move
    {
        public bool This(TextBox box1, TextBox box2, int counter) //Криво работает с autosize textbox'ами
        {
            if (counter > 66)
            {
                return true;
            }
            else if (counter > 25 && counter < 41) //down
            {
                counter += 1;
                box1.Location = new Point(box1.Location.X, box1.Location.Y - 2);
                box2.Location = new Point(box2.Location.X, box2.Location.Y + 2);
            }
            else if (counter <= 25) //right
            {
                counter += 1;
                box1.Location = new Point(box1.Location.X + 2, box1.Location.Y);
            }
            else if (counter >= 41) //left
            {
                counter += 1;
                box1.Location = new Point(box1.Location.X - 2, box1.Location.Y);
            }
            return false;
        }
        public void Change(ref TextBox box1, ref TextBox box2, int x1, int y1, string s1, int x2, int y2, string s2)
        {
            box1.Location = new Point(x2, y2);
            box1.Text = s2;
            box2.Location = new Point(x1, y1);
            box2.Text = s1;
        }
    }

}