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

            int i;

            do
            {
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1: Console.WriteLine("ONE"); break;
                    case 2: Console.WriteLine("TWO"); break;
                    case 3: Console.WriteLine("THREE"); break;
                }
                
            } while (i != 3);
                

        }
    }
}
