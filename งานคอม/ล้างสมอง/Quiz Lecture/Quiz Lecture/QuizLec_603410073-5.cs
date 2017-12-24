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
            string n;
            do
            {
                Int64 b, c = 0, d = 0, e = 0, f, i;
                Console.Write("\n Input your number : ");
                n = Console.ReadLine();
                bool z = Int64.TryParse(n, out b);
                f = b;
                if (z)
                {
                    for (i = 1; i <= b; i += 2)
                    {
                        c += i;
                    }
                    Console.WriteLine(" Summation of Even Number = " + c);
                    for (i = 0; i <= b; i += 2)
                    {
                        d += i;
                    }
                    Console.WriteLine(" Summation of Odd Number = " + d);
                    for (i = 1; i <= b; i++)
                    {
                        e += i;
                    }
                    Console.WriteLine(" Summation of 1 to N = " + e);
                    for (i = 1; i < b; i++)
                    {
                        f = f * i;
                    }
                    Console.WriteLine(" Summation of Factorial = " + f);
                }
                else if (n!="exit") Console.WriteLine(" Try gain");
            } while (n != "exit");
        }
    }
}
