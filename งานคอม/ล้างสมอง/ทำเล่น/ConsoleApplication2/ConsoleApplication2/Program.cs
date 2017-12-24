using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;string[,] a = new string[,]
                {
                {"a","b" },
                {"c","d" },
                };
            while(i<a.Length)
                {
                   Console.Write(a[i,i-1]);
                i++;
                }
        }
    }
}
