using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Code
{
    public class Class1_1
    {
        public string Path { get; set; }
        public Class1_1(string path)
        {
            Path = path;
        }
        public void Process(out int strings, out int symbols)
        {
            string[] lines = File.ReadAllLines(Path).ToArray();
            int str;
            int symb = 0;
            str = lines.Length;
            foreach (var item in lines)
            {
                symb += item.Length;
            }
            strings = str;
            symbols = symb;
        }
    }
}
