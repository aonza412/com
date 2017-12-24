using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace รื้อฟื้นconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 15, 42, 13, 4, 65 };
            Array.Sort(number);
            Array.Reverse(number);
            for(int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i]+" ");
            }

        }
    }
}
