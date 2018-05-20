using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Code
{
    public class Class2_1
    {
        public string Pathfromstring { get; set; }
        public Class2_1(string path)
        {
            Pathfromstring = path;
        }
        public bool Process()
        {
            string fullpath, e;
            try
            {
                fullpath = Path.GetFullPath(Pathfromstring);
                e = Path.GetExtension(Pathfromstring);                
            }
            catch (Exception)
            {
                return false;
            }
            if (e.Length > 0 & fullpath != null & !File.Exists(fullpath))
            {
                bool b = true;
                try
                {
                    File.Create(fullpath);
                }
                catch (Exception)
                {
                    b = false; 
                }
                if (b)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
    }
}
