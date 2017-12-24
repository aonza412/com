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
            int a; 
            do
            {
                Console.WriteLine("When you want to end program pleas enter text : 0");
                Console.Write("Input Size diamon : ");
                a = int.Parse(Console.ReadLine());
                for (int i = 1; i <= a; i++)
                {
                    for (int b = 0; b < (a - i); b++){ Console.Write(" "); }
                    for (int c = 1; c <= i; c++){ Console.Write("*"); }
                    for (int d = 1; d < i; d++) { Console.Write("*"); }
                    Console.WriteLine();
                }
                for (int i = a - 1; i >= 1; i--)
                {
                    for (int e = 0; e < (a - i); e++) { Console.Write(" "); }
                    for (int f = 1; f <= i; f++) { Console.Write("*"); }
                    for (int g = 1; g < i; g++) { Console.Write("*"); }
                    Console.WriteLine();
                }
            } while (a != 0) ;
        }
    }
}

