using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Code
{
    public class Class4_1
    {
        public string Pathfrom { get; set; }
        public Class4_1(string path)
        {
            Pathfrom = path;
        }
        public int Process()
        {
            string text = File.ReadAllText(Pathfrom);            
            return Search(text, text.Length);
        }
        public int Search(string textstring, int n)
        {            
            if	(n != 1)
			{
                if (Convert.ToChar(textstring.Substring(n - 1, 1)) == ',')
                {
                    n--;
                    return Search(textstring, n) + 1;
                }
                else
                {
                    n--;
                    return Search(textstring, n);
                }
            }
			else
			{
                if (Convert.ToChar(textstring.Substring(0, 1)) == ',')
                {                    
                    return 1;
                }
                else
                {                   
                    return 0;
                }
            }
            
        }

    }
}
