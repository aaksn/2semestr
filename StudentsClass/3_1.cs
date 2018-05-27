using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Code
{
    public class Serialization
    {
        public List<Student> Students { get; set; }
        BinaryFormatter formatter = new BinaryFormatter();
        public void DeSerialize(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                Students = (List<Student>)formatter.Deserialize(fs);
            }
        }
        public void Serialize(string path)
        {            
            List<Student> students = new List<Student>();
            for (int i = 0; i < 8; i++)
            {
                students.Add(RandomStudent(i));
            }
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(fs, students);
            }
        }        
        public string Marks(int numofstud)
        {
            string res = "";
            for (int i = 0; i < 10; i++)
            {
                res += Students[numofstud].MedB[i].ToString();
                res += " ";
            }
            return res;
        }
        private Student RandomStudent(int seed)
        {            
            string[] firstnames = new string[] { "Ivan", "Kamaz", "Vadim", "Ruslan", "Anton", "Kirill", "Oleg" };
            string[] secondnames = new string[] { "Magomedov", "Pogorelov", "Turov", "Bragin", "Prokofiev", "Melnik", "Kirimov" };
            Thread.Sleep(20); // For Random
            Random rnd = new Random();
            double[] marks = new double[10];
            for (int i = 0; i < 10; i++)
            {
                Random r = new Random();
                if (seed > 1 && seed < 5)
                    marks[i] = r.Next(seed, 5) + (double)r.Next(11) / 10;
                else marks[i] = r.Next(2, 5) + (double)r.Next(11)/10;
                Thread.Sleep(20); // For Random
            }
            return new Student(firstnames[rnd.Next(80)%7] + " "+ secondnames[rnd.Next(70)%7], Convert.ToDateTime("27.04.1999"), marks, 5, 1);
        }

    }
}
