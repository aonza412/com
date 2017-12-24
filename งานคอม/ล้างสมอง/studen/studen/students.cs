using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studen
{
    public class students
    {
        public string name = "aon";
        public double score = 100;
        public DateTime brithday = DateTime.Now;

        public students()
        {
            string file = System.IO.File.ReadAllText(@"C:\Users\aonza412\Desktop\งานคอม\s1.txt");
            string[] stuData = file.Split(' ');
            this.name = stuData[0];
            this.score = double.Parse(stuData[1]);
        }
    }
}
