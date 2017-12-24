using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10000; //เก็บค่าจุดทศนิยม 10,000  double ใช้เก็บค่าที่เป็นจุดทศนิยม
            string b = "AON"; //string ใช้เก็บค่าตัวหนังสือ
            char c = 'F';
            int d;
            Console.Write(a+"\n"+b+"\n"+c+"\nin put number : ");
            d = int.Parse(Console.ReadLine());
            int e = Math.Pow( d , 2);
            Console.WriteLine(Math.Pow(d,2));



        }
    }
}
