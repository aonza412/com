using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("in put string");
            char[] a = Console.ReadLine().ToCharArray();
            Array.Reverse(a);
            Console.WriteLine(a);
        }
    }
}
