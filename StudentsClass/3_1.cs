using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Code
{
    public class Class3_1
    {    
        public bool Process(int numofstud, Student[] students)
        {
            bool ok = true;			
			foreach (var item in students[numofstud].MedB)
			{
				if (item < 3)
				{
					ok = false;
				}
			}	
            return ok;
        }        
       
    }
}
