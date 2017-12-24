using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.Write("in put value a : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("in put value b : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("in put value c : ");
            c = int.Parse(Console.ReadLine());
            Console.Write("in put value d : ");
            d = int.Parse(Console.ReadLine());

            int x = Math.Sqrt(Math.Pow((((3 * a * c) - (Math.Pow(b, 2))) / (9 * Math.Pow(a, 2))),3) + (Math.Pow(d, 2)));
            Console.WriteLine(" X = "+x);






        }
    }
}
